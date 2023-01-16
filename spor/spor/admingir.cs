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
    public partial class admingir : Form
    {
        public admingir()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("datasource=localhost;username=root;port=3306;password=");
        MySqlDataAdapter adapter;
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
                    string str = "SELECT user,pass From kusay.adminuser Where user='" + textBox1.Text + "'And pass='" + textBox2.Text + "'";
                    adapter = new MySqlDataAdapter(str, con);
                    adapter.Fill(dt);
                    if (dt.Rows.Count <= 0)
                    {
                        MessageBox.Show("username or password are invalide ! ");
                    }
                    else
                    {
                        admin ad = new admin();
                        ad.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "message");
                }
            }
        }
    }
}
