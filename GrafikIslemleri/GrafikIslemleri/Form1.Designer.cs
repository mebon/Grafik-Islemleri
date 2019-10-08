namespace GrafikIslemleri
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonGoruntuYukle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDaralt = new System.Windows.Forms.Button();
            this.buttonGenislet = new System.Windows.Forms.Button();
            this.buttonUfalt = new System.Windows.Forms.Button();
            this.buttonBuyult = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSag = new System.Windows.Forms.Button();
            this.buttonAsagi = new System.Windows.Forms.Button();
            this.buttonSola = new System.Windows.Forms.Button();
            this.buttonYukari = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonTekrarkucult = new System.Windows.Forms.Button();
            this.buttonTekrarBuyult = new System.Windows.Forms.Button();
            this.textBoxBuyutmeTekrari = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonOransal = new System.Windows.Forms.Button();
            this.textBoxOransal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonSaatTersi = new System.Windows.Forms.Button();
            this.buttonSaatYonu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelGoruntu = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.labelwidth = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelyükseklik = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonDaireyeCevir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonDondur = new System.Windows.Forms.Button();
            this.buttonDurdur = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel8 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
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
            // textBoxBuyutmeTekrari
            // 
            this.textBoxBuyutmeTekrari.Location = new System.Drawing.Point(88, 100);
            this.textBoxBuyutmeTekrari.Name = "textBoxBuyutmeTekrari";
            this.textBoxBuyutmeTekrari.Size = new System.Drawing.Size(100, 20);
            this.textBoxBuyutmeTekrari.TabIndex = 2;
            this.textBoxBuyutmeTekrari.Text = "1";
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
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.buttonOransal);
            this.panel5.Controls.Add(this.textBoxOransal);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(300, 448);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(279, 212);
            this.panel5.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(30, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 12);
            this.label11.TabIndex = 4;
            this.label11.Text = "*Ondalıklı sayı yazarken \", (virgül)\" kullanınız.";
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
            // textBoxOransal
            // 
            this.textBoxOransal.Location = new System.Drawing.Point(32, 97);
            this.textBoxOransal.Name = "textBoxOransal";
            this.textBoxOransal.Size = new System.Drawing.Size(100, 20);
            this.textBoxOransal.TabIndex = 2;
            this.textBoxOransal.Text = "0,5";
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
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.buttonSaatTersi);
            this.panel6.Controls.Add(this.buttonSaatYonu);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(15, 448);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(279, 212);
            this.panel6.TabIndex = 5;
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
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox.Location = new System.Drawing.Point(285, 121);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(279, 212);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
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
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.labelwidth);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.pictureBox);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.labelGoruntu);
            this.panel7.Controls.Add(this.labelyükseklik);
            this.panel7.Location = new System.Drawing.Point(15, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(849, 430);
            this.panel7.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(0, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "5 pixel üzerinden işlemler gerçekleştirilir.";
            // 
            // labelwidth
            // 
            this.labelwidth.AutoSize = true;
            this.labelwidth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelwidth.Location = new System.Drawing.Point(52, 34);
            this.labelwidth.Name = "labelwidth";
            this.labelwidth.Size = new System.Drawing.Size(15, 15);
            this.labelwidth.TabIndex = 6;
            this.labelwidth.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(4, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Genişlik : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(3, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Yükseklik : ";
            // 
            // labelyükseklik
            // 
            this.labelyükseklik.AutoSize = true;
            this.labelyükseklik.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelyükseklik.Location = new System.Drawing.Point(67, 19);
            this.labelyükseklik.Name = "labelyükseklik";
            this.labelyükseklik.Size = new System.Drawing.Size(15, 15);
            this.labelyükseklik.TabIndex = 5;
            this.labelyükseklik.Text = "0";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonDaireyeCevir
            // 
            this.buttonDaireyeCevir.Location = new System.Drawing.Point(0, 2);
            this.buttonDaireyeCevir.Name = "buttonDaireyeCevir";
            this.buttonDaireyeCevir.Size = new System.Drawing.Size(279, 23);
            this.buttonDaireyeCevir.TabIndex = 11;
            this.buttonDaireyeCevir.Text = "Daireye Çevir";
            this.buttonDaireyeCevir.UseVisualStyleBackColor = true;
            this.buttonDaireyeCevir.Click += new System.EventHandler(this.buttonDaireyeCevir_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonDondur
            // 
            this.buttonDondur.Location = new System.Drawing.Point(284, 2);
            this.buttonDondur.Name = "buttonDondur";
            this.buttonDondur.Size = new System.Drawing.Size(133, 23);
            this.buttonDondur.TabIndex = 12;
            this.buttonDondur.Text = "Döndür";
            this.buttonDondur.UseVisualStyleBackColor = true;
            this.buttonDondur.Click += new System.EventHandler(this.buttonDondur_Click);
            // 
            // buttonDurdur
            // 
            this.buttonDurdur.Location = new System.Drawing.Point(429, 2);
            this.buttonDurdur.Name = "buttonDurdur";
            this.buttonDurdur.Size = new System.Drawing.Size(133, 23);
            this.buttonDurdur.TabIndex = 13;
            this.buttonDurdur.Text = "Durdur";
            this.buttonDurdur.UseVisualStyleBackColor = true;
            this.buttonDurdur.Click += new System.EventHandler(this.buttonDurdur_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.button1);
            this.panel8.Controls.Add(this.button2);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Location = new System.Drawing.Point(-1, -1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(279, 212);
            this.panel8.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Saat Tersi Yönünde Döndür";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(66, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Saat Yönünde Döndür";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(3, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Döndürme";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.button3);
            this.panel9.Controls.Add(this.button4);
            this.panel9.Controls.Add(this.label12);
            this.panel9.Location = new System.Drawing.Point(-1, -1);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(279, 212);
            this.panel9.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(66, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Saat Tersi Yönünde Döndür";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(66, 62);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Saat Yönünde Döndür";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(3, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "Döndürme";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.buttonDaireyeCevir);
            this.panel10.Controls.Add(this.buttonDurdur);
            this.panel10.Controls.Add(this.buttonDondur);
            this.panel10.Location = new System.Drawing.Point(15, 663);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(564, 29);
            this.panel10.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 694);
            this.Controls.Add(this.panel10);
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
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
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
        private System.Windows.Forms.Label labelwidth;
        private System.Windows.Forms.Label labelyükseklik;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonDaireyeCevir;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonDondur;
        private System.Windows.Forms.Button buttonDurdur;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel10;
    }
}

