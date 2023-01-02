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
    public partial class ayarlar : Form
    {
        string name;
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=teknomarkt;Uid=root;Pwd='mysql1234';");
        public ayarlar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text !="" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("update kullanici set Ad = '" + this.textBox1.Text + "' ,Soyad = '" + this.textBox2.Text + "', kullanici_adi = '" + this.textBox3.Text + "', email = '" + this.textBox4.Text + "', adres = '" + this.textBox5.Text + "' where kullanici_adi = '" + name + "'", con);
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {

                }
                MessageBox.Show("Güncellendi.");
                con.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("boş alan bırakmayınız.");
            }
            
        }

        private void ayarlar_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from kullanici where kullanici_adi='" + name + "'", con);
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                textBox1.Text= read["Ad"].ToString();
                textBox2.Text= read["Soyad"].ToString();
                textBox3.Text = read["kullanici_adi"].ToString();
                textBox4.Text = read["email"].ToString();
                textBox5.Text= read["adres"].ToString();
            }
            con.Close();
        }


        public void prfal(string ad)
        {
            name = ad;

        }
        public override string ToString()
        {
            return name;
        }






    }
}
