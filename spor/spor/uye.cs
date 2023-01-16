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
    public partial class uye : Form
    {
        public uye()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=localhost;database=kusay;port=3306;username=root;password=");

        private void uye_Load(object sender, EventArgs e)
        {
            for (int i = 1975; i <= 2023; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
            comboBox2.Items.Add("Sabah");
            comboBox2.Items.Add("öğleden sonra");
            comboBox2.Items.Add("akşam");
            comboBox3.Items.Add("4 ay");
            comboBox3.Items.Add("6 ay");
            comboBox3.Items.Add("1 yıl");
            comboBox3.Items.Add("2 yıl");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Lutfen ta, belge gir");
                }
                else
                {
                    string str = "insert into ekle values(@id,@adi,@soyadi,@yas,@zaman,@ay)";
                    MySqlCommand cmd = new MySqlCommand(str, con);
                    cmd.Parameters.AddWithValue("@adi", textBox1.Text);
                    cmd.Parameters.AddWithValue("@id", textBox3.Text);
                    cmd.Parameters.AddWithValue("@soyadi", textBox2.Text);
                    cmd.Parameters.AddWithValue("@yas", comboBox1.SelectedItem);
                    cmd.Parameters.AddWithValue("@zaman", comboBox2.SelectedItem);
                    cmd.Parameters.AddWithValue("@ay", comboBox3.SelectedItem);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("yükleme yapıldı");
                    this.Close();
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }
        }
    }
}
