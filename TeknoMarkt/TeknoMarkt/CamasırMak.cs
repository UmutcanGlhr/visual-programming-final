using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace TeknoMarkt
{
    public partial class CamasırMak : Form
    {
        object[] sayılar = new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
       
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=teknomarkt;Uid=root;Pwd='mysql1234';");
        public CamasırMak()
        {
            InitializeComponent();
           
            comboBox3.Items.AddRange(sayılar);
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CamasırMak_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlDataAdapter sqlda = new MySqlDataAdapter("select * from camasirmak", con);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="" && textBox2.Text!="" && comboBox3.Text!="")
            {
                string tur = "camasirmak";
                satinAl stn = new satinAl();
                stn.urunleriAl(textBox1.Text, textBox2.Text, comboBox3.Text, tur);
                stn.ShowDialog();
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız");
            }

        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            Mağaza mgz = new Mağaza();
            this.Hide();
            mgz.ShowDialog();
            this.Close();
        }
    }
}
