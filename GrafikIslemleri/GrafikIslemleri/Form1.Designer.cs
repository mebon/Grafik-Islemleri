﻿namespace GrafikIslemleri
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonGoruntuYukle = new System.Windows.Forms.Button();
            this.buttonYukari = new System.Windows.Forms.Button();
            this.buttonSola = new System.Windows.Forms.Button();
            this.buttonAsagi = new System.Windows.Forms.Button();
            this.buttonSag = new System.Windows.Forms.Button();
            this.buttonBuyult = new System.Windows.Forms.Button();
            this.buttonUfalt = new System.Windows.Forms.Button();
            this.textBoxBuyutmeTekrari = new System.Windows.Forms.TextBox();
            this.buttonTekrarBuyult = new System.Windows.Forms.Button();
            this.buttonTekrarkucult = new System.Windows.Forms.Button();
            this.textBoxOransal = new System.Windows.Forms.TextBox();
            this.buttonOransal = new System.Windows.Forms.Button();
            this.buttonSaatYonu = new System.Windows.Forms.Button();
            this.buttonSaatTersi = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelGoruntu = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonGenislet = new System.Windows.Forms.Button();
            this.buttonDaralt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonGoruntuYukle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(870, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 212);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonDaralt);
            this.panel2.Controls.Add(this.buttonGenislet);
            this.panel2.Controls.Add(this.buttonUfalt);
            this.panel2.Controls.Add(this.buttonBuyult);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(870, 448);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 212);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonSag);
            this.panel3.Controls.Add(this.buttonAsagi);
            this.panel3.Controls.Add(this.buttonSola);
            this.panel3.Controls.Add(this.buttonYukari);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(870, 230);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(279, 212);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.buttonTekrarkucult);
            this.panel4.Controls.Add(this.buttonTekrarBuyult);
            this.panel4.Controls.Add(this.textBoxBuyutmeTekrari);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(585, 448);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(279, 212);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resim Yukleme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Büyültme Küçültme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Öteleme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Büyütme Tekrarı";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.buttonOransal);
            this.panel5.Controls.Add(this.textBoxOransal);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(300, 448);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(279, 212);
            this.panel5.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Oransal Katsayı";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.buttonSaatTersi);
            this.panel6.Controls.Add(this.buttonSaatYonu);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(15, 448);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(279, 212);
            this.panel6.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Döndürme";
            // 
            // buttonGoruntuYukle
            // 
            this.buttonGoruntuYukle.Location = new System.Drawing.Point(87, 85);
            this.buttonGoruntuYukle.Name = "buttonGoruntuYukle";
            this.buttonGoruntuYukle.Size = new System.Drawing.Size(110, 23);
            this.buttonGoruntuYukle.TabIndex = 1;
            this.buttonGoruntuYukle.Text = "Görüntü Yükle";
            this.buttonGoruntuYukle.UseVisualStyleBackColor = true;
            this.buttonGoruntuYukle.Click += new System.EventHandler(this.buttonGoruntuYukle_Click);
            // 
            // buttonYukari
            // 
            this.buttonYukari.Location = new System.Drawing.Point(101, 47);
            this.buttonYukari.Name = "buttonYukari";
            this.buttonYukari.Size = new System.Drawing.Size(75, 23);
            this.buttonYukari.TabIndex = 2;
            this.buttonYukari.Text = "Yukarı";
            this.buttonYukari.UseVisualStyleBackColor = true;
            this.buttonYukari.Click += new System.EventHandler(this.buttonYukari_Click);
            // 
            // buttonSola
            // 
            this.buttonSola.Location = new System.Drawing.Point(27, 103);
            this.buttonSola.Name = "buttonSola";
            this.buttonSola.Size = new System.Drawing.Size(75, 23);
            this.buttonSola.TabIndex = 3;
            this.buttonSola.Text = "Sola";
            this.buttonSola.UseVisualStyleBackColor = true;
            this.buttonSola.Click += new System.EventHandler(this.buttonSola_Click);
            // 
            // buttonAsagi
            // 
            this.buttonAsagi.Location = new System.Drawing.Point(101, 156);
            this.buttonAsagi.Name = "buttonAsagi";
            this.buttonAsagi.Size = new System.Drawing.Size(75, 23);
            this.buttonAsagi.TabIndex = 4;
            this.buttonAsagi.Text = "Aşağı";
            this.buttonAsagi.UseVisualStyleBackColor = true;
            this.buttonAsagi.Click += new System.EventHandler(this.buttonAsagi_Click);
            // 
            // buttonSag
            // 
            this.buttonSag.Location = new System.Drawing.Point(173, 103);
            this.buttonSag.Name = "buttonSag";
            this.buttonSag.Size = new System.Drawing.Size(75, 23);
            this.buttonSag.TabIndex = 5;
            this.buttonSag.Text = "Sağa";
            this.buttonSag.UseVisualStyleBackColor = true;
            this.buttonSag.Click += new System.EventHandler(this.buttonSag_Click);
            // 
            // buttonBuyult
            // 
            this.buttonBuyult.Location = new System.Drawing.Point(27, 62);
            this.buttonBuyult.Name = "buttonBuyult";
            this.buttonBuyult.Size = new System.Drawing.Size(75, 23);
            this.buttonBuyult.TabIndex = 2;
            this.buttonBuyult.Text = "Uzat";
            this.buttonBuyult.UseVisualStyleBackColor = true;
            this.buttonBuyult.Click += new System.EventHandler(this.buttonBuyult_Click);
            // 
            // buttonUfalt
            // 
            this.buttonUfalt.Location = new System.Drawing.Point(27, 133);
            this.buttonUfalt.Name = "buttonUfalt";
            this.buttonUfalt.Size = new System.Drawing.Size(75, 23);
            this.buttonUfalt.TabIndex = 3;
            this.buttonUfalt.Text = "Ufalt";
            this.buttonUfalt.UseVisualStyleBackColor = true;
            this.buttonUfalt.Click += new System.EventHandler(this.buttonUfalt_Click);
            // 
            // textBoxBuyutmeTekrari
            // 
            this.textBoxBuyutmeTekrari.Location = new System.Drawing.Point(88, 100);
            this.textBoxBuyutmeTekrari.Name = "textBoxBuyutmeTekrari";
            this.textBoxBuyutmeTekrari.Size = new System.Drawing.Size(100, 20);
            this.textBoxBuyutmeTekrari.TabIndex = 2;
            // 
            // buttonTekrarBuyult
            // 
            this.buttonTekrarBuyult.Location = new System.Drawing.Point(101, 62);
            this.buttonTekrarBuyult.Name = "buttonTekrarBuyult";
            this.buttonTekrarBuyult.Size = new System.Drawing.Size(75, 23);
            this.buttonTekrarBuyult.TabIndex = 3;
            this.buttonTekrarBuyult.Text = "Büyült";
            this.buttonTekrarBuyult.UseVisualStyleBackColor = true;
            this.buttonTekrarBuyult.Click += new System.EventHandler(this.buttonTekrarBuyult_Click);
            // 
            // buttonTekrarkucult
            // 
            this.buttonTekrarkucult.Location = new System.Drawing.Point(101, 133);
            this.buttonTekrarkucult.Name = "buttonTekrarkucult";
            this.buttonTekrarkucult.Size = new System.Drawing.Size(75, 23);
            this.buttonTekrarkucult.TabIndex = 4;
            this.buttonTekrarkucult.Text = "Kucult";
            this.buttonTekrarkucult.UseVisualStyleBackColor = true;
            this.buttonTekrarkucult.Click += new System.EventHandler(this.buttonTekrarkucult_Click);
            // 
            // textBoxOransal
            // 
            this.textBoxOransal.Location = new System.Drawing.Point(32, 97);
            this.textBoxOransal.Name = "textBoxOransal";
            this.textBoxOransal.Size = new System.Drawing.Size(100, 20);
            this.textBoxOransal.TabIndex = 2;
            // 
            // buttonOransal
            // 
            this.buttonOransal.Location = new System.Drawing.Point(155, 95);
            this.buttonOransal.Name = "buttonOransal";
            this.buttonOransal.Size = new System.Drawing.Size(94, 23);
            this.buttonOransal.TabIndex = 3;
            this.buttonOransal.Text = "Oransal Büyült";
            this.buttonOransal.UseVisualStyleBackColor = true;
            this.buttonOransal.Click += new System.EventHandler(this.buttonOransal_Click);
            // 
            // buttonSaatYonu
            // 
            this.buttonSaatYonu.Location = new System.Drawing.Point(66, 62);
            this.buttonSaatYonu.Name = "buttonSaatYonu";
            this.buttonSaatYonu.Size = new System.Drawing.Size(153, 23);
            this.buttonSaatYonu.TabIndex = 2;
            this.buttonSaatYonu.Text = "Saat Yönünde Döndür";
            this.buttonSaatYonu.UseVisualStyleBackColor = true;
            this.buttonSaatYonu.Click += new System.EventHandler(this.buttonSaatYonu_Click);
            // 
            // buttonSaatTersi
            // 
            this.buttonSaatTersi.Location = new System.Drawing.Point(66, 133);
            this.buttonSaatTersi.Name = "buttonSaatTersi";
            this.buttonSaatTersi.Size = new System.Drawing.Size(153, 23);
            this.buttonSaatTersi.TabIndex = 3;
            this.buttonSaatTersi.Text = "Saat Tersi Yönünde Döndür";
            this.buttonSaatTersi.UseVisualStyleBackColor = true;
            this.buttonSaatTersi.Click += new System.EventHandler(this.buttonSaatTersi_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(266, 54);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(323, 303);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // labelGoruntu
            // 
            this.labelGoruntu.AutoSize = true;
            this.labelGoruntu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelGoruntu.Location = new System.Drawing.Point(3, 4);
            this.labelGoruntu.Name = "labelGoruntu";
            this.labelGoruntu.Size = new System.Drawing.Size(47, 15);
            this.labelGoruntu.TabIndex = 0;
            this.labelGoruntu.Text = "Görüntü";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pictureBox);
            this.panel7.Controls.Add(this.labelGoruntu);
            this.panel7.Location = new System.Drawing.Point(15, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(849, 430);
            this.panel7.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonGenislet
            // 
            this.buttonGenislet.Location = new System.Drawing.Point(173, 62);
            this.buttonGenislet.Name = "buttonGenislet";
            this.buttonGenislet.Size = new System.Drawing.Size(75, 23);
            this.buttonGenislet.TabIndex = 4;
            this.buttonGenislet.Text = "Genişlet";
            this.buttonGenislet.UseVisualStyleBackColor = true;
            this.buttonGenislet.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDaralt
            // 
            this.buttonDaralt.Location = new System.Drawing.Point(173, 133);
            this.buttonDaralt.Name = "buttonDaralt";
            this.buttonDaralt.Size = new System.Drawing.Size(75, 23);
            this.buttonDaralt.TabIndex = 5;
            this.buttonDaralt.Text = "Daralt";
            this.buttonDaralt.UseVisualStyleBackColor = true;
            this.buttonDaralt.Click += new System.EventHandler(this.buttonDaralt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 681);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Görüntü İşlemleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonGoruntuYukle;
        private System.Windows.Forms.Button buttonUfalt;
        private System.Windows.Forms.Button buttonBuyult;
        private System.Windows.Forms.Button buttonSag;
        private System.Windows.Forms.Button buttonAsagi;
        private System.Windows.Forms.Button buttonSola;
        private System.Windows.Forms.Button buttonYukari;
        private System.Windows.Forms.Button buttonTekrarkucult;
        private System.Windows.Forms.Button buttonTekrarBuyult;
        private System.Windows.Forms.TextBox textBoxBuyutmeTekrari;
        private System.Windows.Forms.Button buttonOransal;
        private System.Windows.Forms.TextBox textBoxOransal;
        private System.Windows.Forms.Button buttonSaatTersi;
        private System.Windows.Forms.Button buttonSaatYonu;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelGoruntu;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonDaralt;
        private System.Windows.Forms.Button buttonGenislet;
    }
}

