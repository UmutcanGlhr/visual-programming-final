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
    public partial class UrunEkle : Form
    {
        
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=teknomarkt;Uid=root;Pwd='mysql1234';");
        object[] tablo = new object[] {"bzdlb","camasirmak" };
        public UrunEkle()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(tablo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string model = textBox2.Text;
            int stk = Convert.ToInt32(textBox3.Text);
            float fiyat = float.Parse(textBox4.Text);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("insert into "  +comboBox1.Text + "(Ad,Model,Stok,Fiyat) values ('" + ad + "','" + model + "','" + stk+ "','" + fiyat + "');", con);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (textBox1.Text!="" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                while (reader.Read())
                {
                    
                }
                MessageBox.Show("Eklendi");
                
            }
            else
            {
                MessageBox.Show("Boş Alan");
            }
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            reader.Close();
            cmd.Dispose();
            con.Close();
        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
