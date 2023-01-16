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
    public partial class personel : Form
    {
        public personel()
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
                else
                {
                    string str = "insert into personel values(@adi,@soyadi,@ucret)";
                    MySqlCommand cmd = new MySqlCommand(str, con);
                    cmd.Parameters.AddWithValue("@adi", textBox1.Text);
                    cmd.Parameters.AddWithValue("@soyadi", textBox2.Text);
                    cmd.Parameters.AddWithValue("@ucret", textBox3.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("personel oluşturuldu");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message");
            }
            this.Close();
        }
    }
}
