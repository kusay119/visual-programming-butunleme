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
    public partial class odeme : Form
    {
        public odeme()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=localhost;database=kusay;port=3306;username=root;password=");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "insert into odeme values(@id,@adi,@soyadi,@od,@odk)";
                MySqlCommand cmd = new MySqlCommand(str, con);
                cmd.Parameters.AddWithValue("@id", textBox5.Text);
                cmd.Parameters.AddWithValue("@adi", textBox1.Text);
                cmd.Parameters.AddWithValue("@soyadi", textBox2.Text);
                cmd.Parameters.AddWithValue("@od", textBox3.Text);
                cmd.Parameters.AddWithValue("odk", textBox4.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Başarıyla yüklendi");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }
        }
    }
}
