using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imgAppFatihOrgen
{
    public partial class Form2 : Form
    {
        Bitmap resimkaynak;
        public Form2()
        {
            InitializeComponent();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resimsonuc = openFileDialog1.ShowDialog();
            if (resimsonuc == DialogResult.OK)
            {
                resimkaynak = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = resimkaynak;
            }
        }

        private void renkAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);

            Color renk = resimkaynak.GetPixel(x,y);
            renkAlToolStripMenuItem.BackColor = renk;
            pictureBox2.BackColor = renk;
        }
    }
}
