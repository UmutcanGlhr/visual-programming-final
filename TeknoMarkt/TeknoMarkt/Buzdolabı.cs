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
    public partial class Buzdolabı : Form
    {
        
        object[] sayılar = new object[] {"1","2","3","4","5","6","7","8","9","10","11","12"};
     
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=teknomarkt;Uid=root;Pwd='mysql1234';");
        public Buzdolabı()
        {
            InitializeComponent();
            
            comboBox3.Items.AddRange(sayılar);
            
        }

        private void Buzdolabı_Load(object sender, EventArgs e)
        {
            
            con.Open();
            MySqlDataAdapter sqlda = new MySqlDataAdapter("select * from bzdlb", con);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!=""&&textBox2.Text!=""&&comboBox3.Text!="")
            {
                string tur = " bzdlb";
                satinAl stnal = new satinAl();
                stnal.urunleriAl(textBox1.Text, textBox2.Text, comboBox3.Text, tur);
                stnal.ShowDialog();
            }
            else
            {
                MessageBox.Show("boş alan bırakmayınız");
            }
            



            
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
