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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            uye u = new uye();
            u.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            uye u = new uye();
            u.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sorgu i = new sorgu();
            i.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            sorgu i = new sorgu();
            i.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            odeme o = new odeme();
            o.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            odeme o = new odeme();
            o.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ODEMESOR od = new ODEMESOR();
            od.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ODEMESOR od = new ODEMESOR();
            od.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            admingir o = new admingir();
            o.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            admingir o = new admingir();
            o.ShowDialog();
        }
    }
}
