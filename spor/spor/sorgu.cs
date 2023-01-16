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
    public partial class sorgu : Form
    {
        public sorgu()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=localhost;database=kusay;port=3306;username=root;password=");
        MySqlDataAdapter ad;
        DataTable dt = new DataTable();
        private void sorgu_Load(object sender, EventArgs e)
        {
                for (int i = 1975; i <= 2023; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
            comboBox2.Items.Add("sabah");
            comboBox2.Items.Add("öğleden sonra");
            comboBox2.Items.Add("akşam");
            comboBox3.Items.Add("4 ay");
            comboBox3.Items.Add("6 ay");
            comboBox3.Items.Add("1 yıl");
            comboBox3.Items.Add("2 yıl");
            try
            {
                ad = new MySqlDataAdapter("Select * From ekle", con);
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.SelectedItem = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox2.SelectedItem = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox3.SelectedItem = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
         
                string str = "UPDATE ekle SET id=@id, adi=@adi,soyadi=@soyadi,yas=@yas,zaman=@zaman,ay=@ay where id=" + dataGridView1.CurrentRow.Cells[0].Value + "";
                MySqlCommand cmd = new MySqlCommand(str, con);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.Parameters.AddWithValue("@adi", textBox2.Text);
                cmd.Parameters.AddWithValue("@soyadi", textBox3.Text);
                cmd.Parameters.AddWithValue("@yas", comboBox1.SelectedItem);
                cmd.Parameters.AddWithValue("@zaman", comboBox2.SelectedItem);
                cmd.Parameters.AddWithValue("@ay", comboBox3.SelectedItem);
                con.Open();
                cmd.ExecuteNonQuery();
           
                con.Close();
                dataGridView1.DataSource = dt;
                MessageBox.Show("Değiştirilmiş");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string removeVolCred = "DELETE FROM ekle WHERE id="+textBox1.Text+"";
            MySqlCommand command = new MySqlCommand(removeVolCred, con);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sildim");
        }
    }
}
