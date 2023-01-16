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
    public partial class olus : Form
    {
        public olus()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=localhost;database=kusay;port=3306;username=root;password=");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
 if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Lufen bilgi gir");
            }
            else {
                    string str = "insert into login values(@username,@password)";
                    MySqlCommand cmd = new MySqlCommand(str,con);
                    cmd.Parameters.AddWithValue("@username", textBox1.Text);
                    cmd.Parameters.AddWithValue("@password", textBox2.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("hisap oluşturuldu");

            }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "message");
            }
            this.Close();
        }
    }
}
