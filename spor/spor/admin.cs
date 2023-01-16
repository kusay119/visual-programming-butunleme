using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spor
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            calis a = new calis();
            a.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            calis a = new calis();
            a.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            personel p = new personel();
            p.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            personel p = new personel();
            p.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            personelbak bak = new personelbak();
            bak.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            personelbak bak = new personelbak();
            bak.ShowDialog();
        }
    }
}
