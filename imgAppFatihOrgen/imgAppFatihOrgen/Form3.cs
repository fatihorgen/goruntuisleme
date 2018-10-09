using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imgAppFatihOrgen
{
    public partial class Form3 : Form
    {
        Bitmap resimkaynak, islem;
        public Form3()
        {
            InitializeComponent();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                resimkaynak = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = resimkaynak;
            }
        }

        private void ortlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            int genislik = resimkaynak.Width;
            int yukseklik = resimkaynak.Height;
            islem = new Bitmap(genislik, yukseklik);
            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    Color renkal = resimkaynak.GetPixel(x, y);
                    double griyap = ((renkal.R) + (renkal.G) + (renkal.B))/3;
                    int griInt = Convert.ToInt32(griyap);
                    Color grirenk = Color.FromArgb(griInt, griInt, griInt);
                    islem.SetPixel(x, y, grirenk);
                }
            }
            pictureBox2.Image = islem;
        }

        private void lumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            int genislik = resimkaynak.Width;
            int yukseklik = resimkaynak.Height;
            islem = new Bitmap(genislik, yukseklik);
            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    Color renkal = resimkaynak.GetPixel(x, y);
                    double griyap = (renkal.R * 0.3) + (renkal.G * 0.59) + (renkal.B * 0.11);
                    int griInt = Convert.ToInt32(griyap);
                    Color grirenk = Color.FromArgb(griInt, griInt, griInt);
                    islem.SetPixel(x, y, grirenk);
                }
            }
            pictureBox2.Image = islem;
        }

        private void açıklıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            int genislik = resimkaynak.Width;
            int yukseklik = resimkaynak.Height;
            islem = new Bitmap(genislik, yukseklik);
            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    Color renkal = resimkaynak.GetPixel(x, y);
                    int[] renkdizi = { renkal.R, renkal.G, renkal.B };
                    double griyap = (renkdizi.Max() + renkdizi.Min())/2;
                    int griInt = Convert.ToInt32(griyap);
                    Color grirenk = Color.FromArgb(griInt, griInt, griInt);
                    islem.SetPixel(x, y, grirenk);
                }
            }
            pictureBox2.Image = islem;
        }

        private void kanalÇıkarımıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            int genislik = resimkaynak.Width;
            int yukseklik = resimkaynak.Height;
            islem = new Bitmap(genislik, yukseklik);
            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    Color renkal = resimkaynak.GetPixel(x, y);
                    double griyap = renkal.R;
                    int griInt = Convert.ToInt32(griyap);
                    Color grirenk = Color.FromArgb(griInt, griInt, griInt);
                    islem.SetPixel(x, y, grirenk);
                }
            }
            pictureBox2.Image = islem;
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG|*.png";
            DialogResult sonuc = saveFileDialog1.ShowDialog();
            ImageFormat format = ImageFormat.Png;
            if (sonuc == DialogResult.OK)
            {
                islem.Save(saveFileDialog1.FileName, format);
            }
        }

        private void bt709ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            int genislik = resimkaynak.Width;
            int yukseklik = resimkaynak.Height;
            islem = new Bitmap(genislik,yukseklik);
            for (int y = 0; y<yukseklik; y++)
            {
                for (int x=0; x<genislik; x++)
                {
                    Color renkal = resimkaynak.GetPixel(x,y);
                    double griyap = (renkal.R * 0.2125) +(renkal.G * 0.7154) +(renkal.B * 0.072);
                    int griInt = Convert.ToInt32(griyap);
                    Color grirenk = Color.FromArgb(griInt, griInt, griInt);
                    islem.SetPixel(x,y,grirenk);
                }
            }
            pictureBox2.Image = islem;
        }
    }
}
