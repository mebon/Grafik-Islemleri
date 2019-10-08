using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Media;
using System.Drawing.Drawing2D;

namespace GrafikIslemleri
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonSaatYonu_Click(object sender, EventArgs e)
        {
            if(bmp != null)
            {
                int w = pictureBox.Width;
                pictureBox.Width = pictureBox.Height;
                pictureBox.Height = w;
                bmp.RotateFlip(RotateFlipType.Rotate90FlipY);
                bmp.RotateFlip(RotateFlipType.RotateNoneFlipY);
                pictureBox.Image = bmp;
            }
        }
        private void buttonSaatTersi_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                int w = pictureBox.Width;
                pictureBox.Width = pictureBox.Height;
                pictureBox.Height = w;
                bmp.RotateFlip(RotateFlipType.Rotate270FlipX);
                bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
                pictureBox.Image = bmp;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 50;
            timer2.Interval = 50;
            labelwidth.Text = pictureBox.Width.ToString();
            labelyükseklik.Text = pictureBox.Height.ToString();
            if(pictureBox != null)
            {
                try
                {
                    int w = pictureBox.Width;
                    pictureBox.Width = pictureBox.Height;
                    pictureBox.Height = w;
                    bmp = (Bitmap)Bitmap.FromFile(@"dpulogo.png");
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Image = bmp;
                }
                catch (Exception)
                {
                    MessageBox.Show("Dosya bulunamadı.");
                }
            }
           
        }
        private void buttonGoruntuYukle_Click(object sender, EventArgs e)
        {
            if (pictureBox != null)
            {
                try
                {
                    openFileDialog1.ShowDialog();
                    pictureBox.ImageLocation = openFileDialog1.FileName;
                    bmp = (Bitmap)Bitmap.FromFile(openFileDialog1.FileName);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    int w = pictureBox.Width;
                    pictureBox.Width = pictureBox.Height;
                    pictureBox.Height = w;
                    labelwidth.Text = pictureBox.Width.ToString();
                    labelyükseklik.Text = pictureBox.Height.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Dosya bulunamadı.");
                }
            }
        }
        private void buttonYukari_Click(object sender, EventArgs e)
        {
            pictureBox.Top -= 5;

        }
        private void buttonSag_Click(object sender, EventArgs e)
        {
            pictureBox.Left += 5;
        }
        private void buttonSola_Click(object sender, EventArgs e)
        {
            pictureBox.Left -= 5;
        }
        private void buttonAsagi_Click(object sender, EventArgs e)
        {
            pictureBox.Top += 5;
        }
        private void buttonBuyult_Click(object sender, EventArgs e)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Height = pictureBox.Height + 5;
            labelyükseklik.Text = pictureBox.Height.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Width += 5;
            labelwidth.Text = pictureBox.Width.ToString();
        }
        private void buttonUfalt_Click(object sender, EventArgs e)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Height -= 5;
            labelyükseklik.Text = pictureBox.Height.ToString();
        }

        private void buttonDaralt_Click(object sender, EventArgs e)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Width -= 5;
            labelwidth.Text = pictureBox.Width.ToString();
        }
        private void buttonTekrarBuyult_Click(object sender, EventArgs e)
        {
            double tekrar = double.Parse(textBoxBuyutmeTekrari.Text);
            pictureBox.Width = (int)Math.Pow(2.0, tekrar)*pictureBox.Width;
            pictureBox.Height = (int)Math.Pow(2.0, tekrar)*pictureBox.Height;
            labelwidth.Text = pictureBox.Width.ToString();
            labelyükseklik.Text = pictureBox.Height.ToString();
        }
        private void buttonTekrarkucult_Click(object sender, EventArgs e)
        {
            double tekrar = double.Parse(textBoxBuyutmeTekrari.Text);
            pictureBox.Width = (int)(pictureBox.Width / (int)Math.Pow(2.0, tekrar));
            pictureBox.Height = (int)(pictureBox.Height / (int)Math.Pow(2.0, tekrar));
            labelwidth.Text = pictureBox.Width.ToString();
            labelyükseklik.Text = pictureBox.Height.ToString();
        }
        private void buttonOransal_Click(object sender, EventArgs e)
        {
            String oranString = textBoxOransal.Text;
            double oran = Convert.ToDouble(oranString);
            pictureBox.Width =(int)(pictureBox.Width * oran);
            pictureBox.Height = (int)(pictureBox.Height * oran);
            labelwidth.Text = pictureBox.Width.ToString();
            labelyükseklik.Text = pictureBox.Height.ToString();

        }
        bool suruklensinMi = false;
        Point ilkKonumAl;
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            suruklensinMi = true;
            ilkKonumAl = e.Location;
        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (suruklensinMi)
            {
                pictureBox.Left = e.X + pictureBox.Left - (ilkKonumAl.X);
                pictureBox.Top = e.Y + pictureBox.Top - (ilkKonumAl.Y);
            }
        }
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            suruklensinMi = false;
        }
        int sayac;
        private void buttonDaireyeCevir_Click(object sender, EventArgs e)
        {
            sayac = 0;
            timer1.Start();
        }
        private void sekilDegistirme(float derece, int sinir)
        {
            Bitmap bitmap = new Bitmap(pictureBox.Image.Width, pictureBox.Image.Height);
            Graphics grafik = Graphics.FromImage(bitmap);
            grafik.TranslateTransform((float)bitmap.Width / 2, (float)bitmap.Height / 2);
            grafik.RotateTransform(derece);
            grafik.TranslateTransform(-(float)bitmap.Width / 2, -(float)bitmap.Height / 2);
            grafik.InterpolationMode = InterpolationMode.Default;
            grafik.DrawImage(pictureBox.Image, new Point(0, 0));
            grafik.Dispose();
            pictureBox.Image = bitmap;
            sayac++;
            if (sayac == sinir)                timer1.Stop();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sekilDegistirme(10, 36);
        }

        private void buttonDondur_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void buttonDurdur_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sekilDegistirme(10, 3600);
        }
    }
}