using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA23101003
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            btnMentes.Click += BtnMentes_Click;
        }

        private void BtnMentes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxEv.Text)
                || string.IsNullOrWhiteSpace(tbxNev.Text)
                || string.IsNullOrWhiteSpace(tbxSzH.Text)
                || string.IsNullOrWhiteSpace(tbxOrszag.Text))
            {
                MessageBox.Show(
                    caption: "Mentés",
                    text: "Tölts ki minden beviteli mezőt!",
                    icon: MessageBoxIcon.Warning,
                    buttons: MessageBoxButtons.OK);
            }
            else if (int.Parse(tbxEv.Text) <= 1989)
            {
                MessageBox.Show(
                    caption: "Mentés",
                    text: "Hiba! az évszám nem megfelelő!",
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    using var sw = new StreamWriter(@"..\..\..\src\uj_dijazott.txt");
                    sw.WriteLine("Év;Név;SzületésHalálozás;Országkód");
                    sw.WriteLine($"{tbxEv.Text};{tbxNev.Text};{tbxSzH.Text};{tbxOrszag.Text}");

                    tbxEv.Clear();
                    tbxNev.Clear();
                    tbxSzH.Clear();
                    tbxOrszag.Clear();
                }
                catch { MessageBox.Show("Hiba az állomány írásánál!"); }
                
            }
        }
    }
}
