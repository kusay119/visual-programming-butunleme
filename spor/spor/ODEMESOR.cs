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
    public partial class ODEMESOR : Form
    {
        public ODEMESOR()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=localhost;database=kusay;port=3306;username=root;password=");
        MySqlDataAdapter ad;
        DataTable dt = new DataTable();
        private void ODEMESOR_Load(object sender, EventArgs e)
        {
            try
            {
                ad = new MySqlDataAdapter("Select * From odeme", con);
                ad.Fill(dt);
                con.Open();
                dataGridView1.DataSource = dt;
                con.Close();
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
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string str = "UPDATE odeme SET id=@id,adi=@adi,soyadi=@soyadi,od=@od,odk=@odk where id=" + dataGridView1.CurrentRow.Cells[0].Value +"";
                MySqlCommand cmd = new MySqlCommand(str, con);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.Parameters.AddWithValue("@adi", textBox2.Text);
                cmd.Parameters.AddWithValue("@soyadi", textBox3.Text);
                cmd.Parameters.AddWithValue("@od", textBox4.Text);
                cmd.Parameters.AddWithValue("@odk", textBox5.Text);
                cmd.ExecuteNonQuery();
                dataGridView1.DataSource = dt;
                con.Close();
                MessageBox.Show("Başarıyla değiştirildi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message");
            }
        }
    }
}
