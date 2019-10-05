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

namespace GrafikIslemleri
{
    public partial class Form1 : Form
    {

        int aci = 0;
        Bitmap bmp;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSaatYonu_Click(object sender, EventArgs e)
        {
            if(bmp != null)
            {
                 
                bmp.RotateFlip(RotateFlipType.Rotate90FlipY);
                bmp.RotateFlip(RotateFlipType.RotateNoneFlipY);
                pictureBox.Image = bmp;
                
            }

        }
        
        private void buttonSaatTersi_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                bmp.RotateFlip(RotateFlipType.Rotate270FlipX);
                bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);

                pictureBox.Image = bmp;

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if(pictureBox != null)
            {
                try
                {
                    bmp = (Bitmap)Bitmap.FromFile(@"dpulogo.png");
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
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
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            openFileDialog1.ShowDialog();
            pictureBox.ImageLocation = openFileDialog1.FileName;
            bmp = (Bitmap)Bitmap.FromFile(openFileDialog1.FileName);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = bmp;

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
            pictureBox.Height += 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox.Width += 5;
        }

        private void buttonUfalt_Click(object sender, EventArgs e)
        {
            pictureBox.Height -= 5;
        }

        private void buttonDaralt_Click(object sender, EventArgs e)
        {
            pictureBox.Width -= 5;
        }

        private void buttonTekrarBuyult_Click(object sender, EventArgs e)
        {
            int tekrar = int.Parse(textBoxBuyutmeTekrari.Text);
            pictureBox.Width += tekrar*5;
            pictureBox.Height += tekrar*5;
        }

        private void buttonTekrarkucult_Click(object sender, EventArgs e)
        {
            int tekrar = int.Parse(textBoxBuyutmeTekrari.Text);
            pictureBox.Width -= tekrar * 5;
            pictureBox.Height -= tekrar * 5;
        }

        private void buttonOransal_Click(object sender, EventArgs e)
        {
            double tekrar = Convert.ToDouble(textBoxOransal.Text);
            double sayi = 1.0;
            if (tekrar/10 < sayi)
            {
                
                pictureBox.Width -= (int)tekrar;
                pictureBox.Height -= (int)tekrar;
            }
            else if (tekrar/10 > sayi)
            {
               

                pictureBox.Width += (int)tekrar * 5;
                pictureBox.Height += (int)tekrar * 5;
            }
        }

    }
}
