using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace spor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("datasource=localhost;username=root;port=3306;password=");
        MySqlDataAdapter adapter;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Lutfen bilgi gir");
            }
            else
            {
                try
                {

             
                DataTable dt = new DataTable();
                string str = "SELECT username,password From kusay.login Where username='" +textBox1.Text+"'And password='"+textBox2.Text+"'";
                adapter = new MySqlDataAdapter(str, con);
                adapter.Fill(dt);
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("username or password are invalide ! ");
                }
                else
                {
                    home h = new home();
                    h.ShowDialog();
                }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"message");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            olus ol = new olus();
            ol.ShowDialog();
        }
    }
}
