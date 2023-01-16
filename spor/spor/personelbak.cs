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
    public partial class personelbak : Form
    {
        public personelbak()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=localhost;database=kusay;port=3306;username=root;password=");
        MySqlDataAdapter ad;
        DataTable dt = new DataTable();
        private void personelbak_Load(object sender, EventArgs e)
        {
            try
            {


                ad = new MySqlDataAdapter("Select * From personel", con);
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }
        }
    }
}
