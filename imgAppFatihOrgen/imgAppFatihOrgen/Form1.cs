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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void renkAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 renkal = new Form2();
            renkal.ShowDialog();
        }

        private void griYöntemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 griyontem = new Form3();
            griyontem.ShowDialog();
        }
    }
}
