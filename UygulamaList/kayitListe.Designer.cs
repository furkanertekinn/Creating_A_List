﻿namespace UygulamaList
{
    partial class kayitListe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTamamlanamadi = new System.Windows.Forms.Button();
            this.btnTamamlandi = new System.Windows.Forms.Button();
            this.btnTumListe = new System.Windows.Forms.Button();
            this.grpBoxListe = new System.Windows.Forms.GroupBox();
            this.grdListe = new System.Windows.Forms.DataGridView();
            this.btnIptalEdildi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpBoxListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIptalEdildi);
            this.groupBox1.Controls.Add(this.btnTamamlanamadi);
            this.groupBox1.Controls.Add(this.btnTamamlandi);
            this.groupBox1.Controls.Add(this.btnTumListe);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem Listesi";
            // 
            // btnTamamlanamadi
            // 
            this.btnTamamlanamadi.Location = new System.Drawing.Point(7, 128);
            this.btnTamamlanamadi.Name = "btnTamamlanamadi";
            this.btnTamamlanamadi.Size = new System.Drawing.Size(134, 28);
            this.btnTamamlanamadi.TabIndex = 0;
            this.btnTamamlanamadi.Text = "Tamamlanamadı";
            this.btnTamamlanamadi.UseVisualStyleBackColor = true;
            this.btnTamamlanamadi.Click += new System.EventHandler(this.btnTamamlanamadi_Click);
            // 
            // btnTamamlandi
            // 
            this.btnTamamlandi.Location = new System.Drawing.Point(7, 94);
            this.btnTamamlandi.Name = "btnTamamlandi";
            this.btnTamamlandi.Size = new System.Drawing.Size(134, 28);
            this.btnTamamlandi.TabIndex = 0;
            this.btnTamamlandi.Text = "Tamamlandı";
            this.btnTamamlandi.UseVisualStyleBackColor = true;
            this.btnTamamlandi.Click += new System.EventHandler(this.btnTamamlandi_Click);
            // 
            // btnTumListe
            // 
            this.btnTumListe.Location = new System.Drawing.Point(7, 60);
            this.btnTumListe.Name = "btnTumListe";
            this.btnTumListe.Size = new System.Drawing.Size(134, 28);
            this.btnTumListe.TabIndex = 0;
            this.btnTumListe.Text = "Tüm Liste";
            this.btnTumListe.UseVisualStyleBackColor = true;
            this.btnTumListe.Click += new System.EventHandler(this.btnTumListe_Click);
            // 
            // grpBoxListe
            // 
            this.grpBoxListe.Controls.Add(this.grdListe);
            this.grpBoxListe.Location = new System.Drawing.Point(174, 12);
            this.grpBoxListe.Name = "grpBoxListe";
            this.grpBoxListe.Size = new System.Drawing.Size(567, 411);
            this.grpBoxListe.TabIndex = 1;
            this.grpBoxListe.TabStop = false;
            this.grpBoxListe.Text = "Liste";
            // 
            // grdListe
            // 
            this.grdListe.AllowUserToAddRows = false;
            this.grdListe.AllowUserToDeleteRows = false;
            this.grdListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListe.Location = new System.Drawing.Point(3, 16);
            this.grdListe.Name = "grdListe";
            this.grdListe.ReadOnly = true;
            this.grdListe.Size = new System.Drawing.Size(561, 392);
            this.grdListe.TabIndex = 0;
            // 
            // btnIptalEdildi
            // 
            this.btnIptalEdildi.Location = new System.Drawing.Point(6, 162);
            this.btnIptalEdildi.Name = "btnIptalEdildi";
            this.btnIptalEdildi.Size = new System.Drawing.Size(134, 28);
            this.btnIptalEdildi.TabIndex = 0;
            this.btnIptalEdildi.Text = "İptal Edildi";
            this.btnIptalEdildi.UseVisualStyleBackColor = true;
            this.btnIptalEdildi.Click += new System.EventHandler(this.btnIptalEdildi_Click);
            // 
            // kayitListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 430);
            this.Controls.Add(this.grpBoxListe);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "kayitListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Liste";
            this.Load += new System.EventHandler(this.kayitListe_Load);
            this.groupBox1.ResumeLayout(false);
            this.grpBoxListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpBoxListe;
        private System.Windows.Forms.DataGridView grdListe;
        private System.Windows.Forms.Button btnTamamlanamadi;
        private System.Windows.Forms.Button btnTamamlandi;
        private System.Windows.Forms.Button btnTumListe;
        private System.Windows.Forms.Button btnIptalEdildi;
    }
}