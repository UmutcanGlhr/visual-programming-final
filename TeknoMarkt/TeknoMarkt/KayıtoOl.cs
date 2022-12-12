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
    public partial class KayıtoOl : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=teknomarkt;Uid=root;Pwd='mysql1234';");
        public KayıtoOl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        private void login()
        {
            this.Hide();
            GirişEkrani log = new GirişEkrani();
            log.Show();
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            string sifre = textBox3.Text;
            string sfrtkr = textBox4.Text;
            string email = textBox5.Text;
            string adres = textBox6.Text;
            string kadi = textBox7.Text;
            try
            {
                
               
                
                if (ad=="" || soyad == "" || sifre == "" || sfrtkr == "" || email == "" || adres == "" || kadi == "" )
                {
                    MessageBox.Show("Boş Alan Bırakmayınız");
                }
                else if (sifre != sfrtkr)
                {
                    MessageBox.Show("Şifreler Aynı Değil");
                }
                else
                {
                    string Query = "insert into kullanici(Ad,Soyad,kullanici_adi,email,adres,Şifre) values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox7.Text + "','" + this.textBox5.Text + "','" + this.textBox6.Text + "','"+this.textBox3.Text+"');";
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, con);
                    MySqlDataReader MyReader2;
                    con.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    while (MyReader2.Read())
                    {
                    }
                    con.Close();
                    login();
                }

            }
            catch (Exception ex )
            {

                
            }
            
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            login();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
