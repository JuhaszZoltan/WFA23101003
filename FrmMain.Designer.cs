﻿
namespace WFA23101003
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUI01 = new System.Windows.Forms.Label();
            this.tbxEv = new System.Windows.Forms.TextBox();
            this.btnMentes = new System.Windows.Forms.Button();
            this.lblUI02 = new System.Windows.Forms.Label();
            this.tbxNev = new System.Windows.Forms.TextBox();
            this.lblUI03 = new System.Windows.Forms.Label();
            this.tbxSzH = new System.Windows.Forms.TextBox();
            this.lblUI04 = new System.Windows.Forms.Label();
            this.tbxOrszag = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUI01
            // 
            this.lblUI01.AutoSize = true;
            this.lblUI01.Location = new System.Drawing.Point(49, 31);
            this.lblUI01.Name = "lblUI01";
            this.lblUI01.Size = new System.Drawing.Size(35, 25);
            this.lblUI01.TabIndex = 100;
            this.lblUI01.Text = "Év:";
            // 
            // tbxEv
            // 
            this.tbxEv.Location = new System.Drawing.Point(157, 28);
            this.tbxEv.Name = "tbxEv";
            this.tbxEv.Size = new System.Drawing.Size(74, 32);
            this.tbxEv.TabIndex = 1;
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(12, 268);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(343, 46);
            this.btnMentes.TabIndex = 5;
            this.btnMentes.Text = "Adatok mentése";
            this.btnMentes.UseVisualStyleBackColor = true;
            // 
            // lblUI02
            // 
            this.lblUI02.AutoSize = true;
            this.lblUI02.Location = new System.Drawing.Point(49, 91);
            this.lblUI02.Name = "lblUI02";
            this.lblUI02.Size = new System.Drawing.Size(49, 25);
            this.lblUI02.TabIndex = 100;
            this.lblUI02.Text = "Név:";
            // 
            // tbxNev
            // 
            this.tbxNev.Location = new System.Drawing.Point(157, 88);
            this.tbxNev.Name = "tbxNev";
            this.tbxNev.Size = new System.Drawing.Size(198, 32);
            this.tbxNev.TabIndex = 2;
            // 
            // lblUI03
            // 
            this.lblUI03.AutoSize = true;
            this.lblUI03.Location = new System.Drawing.Point(49, 151);
            this.lblUI03.Name = "lblUI03";
            this.lblUI03.Size = new System.Drawing.Size(54, 25);
            this.lblUI03.TabIndex = 100;
            this.lblUI03.Text = "Sz/H:";
            // 
            // tbxSzH
            // 
            this.tbxSzH.Location = new System.Drawing.Point(157, 150);
            this.tbxSzH.Name = "tbxSzH";
            this.tbxSzH.Size = new System.Drawing.Size(151, 32);
            this.tbxSzH.TabIndex = 3;
            // 
            // lblUI04
            // 
            this.lblUI04.AutoSize = true;
            this.lblUI04.Location = new System.Drawing.Point(49, 211);
            this.lblUI04.Name = "lblUI04";
            this.lblUI04.Size = new System.Drawing.Size(75, 25);
            this.lblUI04.TabIndex = 100;
            this.lblUI04.Text = "Ország:";
            // 
            // tbxOrszag
            // 
            this.tbxOrszag.Location = new System.Drawing.Point(157, 211);
            this.tbxOrszag.Name = "tbxOrszag";
            this.tbxOrszag.Size = new System.Drawing.Size(74, 32);
            this.tbxOrszag.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 339);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.tbxOrszag);
            this.Controls.Add(this.lblUI04);
            this.Controls.Add(this.tbxSzH);
            this.Controls.Add(this.lblUI03);
            this.Controls.Add(this.tbxNev);
            this.Controls.Add(this.lblUI02);
            this.Controls.Add(this.tbxEv);
            this.Controls.Add(this.lblUI01);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMain";
            this.Text = "Orvosi Nobel-díjasok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUI01;
        private System.Windows.Forms.TextBox tbxEv;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Label lblUI02;
        private System.Windows.Forms.TextBox tbxNev;
        private System.Windows.Forms.Label lblUI03;
        private System.Windows.Forms.TextBox tbxSzH;
        private System.Windows.Forms.Label lblUI04;
        private System.Windows.Forms.TextBox tbxOrszag;
    }
}

