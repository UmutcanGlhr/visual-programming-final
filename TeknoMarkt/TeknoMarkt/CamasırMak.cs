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
        object[] sayılar1 = new object[] { "23", "24", "25", "26", "27", "28", "29", "30" };
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=teknomarkt;Uid=root;Pwd='mysql1234';");
        public CamasırMak()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(sayılar);
            comboBox3.Items.AddRange(sayılar);
            comboBox2.Items.AddRange(sayılar1);
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
            int toplam;
            int stok = Convert.ToInt32(comboBox3.Text);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select cmStok from camasirmak where cmAd = '" + textBox1.Text + "' AND cmModel = '" + textBox2.Text + "'", con);

            int a = Convert.ToInt32(cmd.ExecuteScalar());

            if (textBox1.Text == "" || textBox2.Text == "" || comboBox3.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Boş Alan Bırakmayınız");
            }
            else
            {

                if (stok > a)
                {
                    MessageBox.Show("stok sayısı yeterli değil");
                }
                else
                {
                    toplam = a - stok;
                    MySqlCommand cmd1 = new MySqlCommand("update camasirmak set cmStok = '" + toplam + "' where cmModel = '" + textBox2.Text + "'", con);
                    MySqlDataReader reader = cmd1.ExecuteReader();
                    while (reader.Read())
                    {

                    }
                    MessageBox.Show("Satın Alınmıştır");
                    reader.Close();
                    cmd1.Dispose();
                }

            }





            cmd.Dispose();
            con.Close();


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
