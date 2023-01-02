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
    public partial class satinAl : Form
    {


        MySqlConnection con = new MySqlConnection("Server=localhost;Database=teknomarkt;Uid=root;Pwd='mysql1234';");
        
        object[] sayılar = new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
       
        object[] sayılar1 = new object[] { "23", "24", "25", "26", "27", "28", "29", "30" };


        string ad;
        string model;
        string stok;
        string tablo;
        public satinAl()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(sayılar);
            comboBox2.Items.AddRange(sayılar1);
            
        }

        private void satinAl_Load(object sender, EventArgs e)
        {
            label1.Text = ad;
            label2.Text = model;
            label3.Text = stok;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int toplam;
            int ss = Convert.ToInt32(stok);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select Stok from "+tablo+" where Ad = '" + ad + "' AND Model = '" + model + "'", con);

            int a = Convert.ToInt32(cmd.ExecuteScalar());
            if (textBox1.Text=="" || comboBox1.Text==""|| comboBox2.Text=="")
            {
                MessageBox.Show("Boş Alan Bırakmayınız");
            }
            else
            {
                
                if (ss> a)
                {
                    MessageBox.Show("stok sayısı yeterli değil");
                }
                else
                {
                    satilan();
                    toplam = a - ss;
                    MySqlCommand cmd1 = new MySqlCommand("update "+tablo+" set Stok = '" + toplam + "' where Model = '" + model + "'", con);
                    MySqlDataReader reader = cmd1.ExecuteReader();
                    while (reader.Read())
                    {
                       

                    }
                    
                    MessageBox.Show("Satın Alınmıştır");
                  
                    reader.Close();
                    cmd1.Dispose();
                    this.Close();
                }

                

            }
            cmd.Dispose();
            con.Close(); 

        }




        public void urunleriAl(string AD, string MODEL, string STOK,string cins)
        {
            ad = AD;
            model = MODEL;
            stok = STOK;
            tablo = cins;

        }
        public override string ToString()
        {
            return ad + model + stok + tablo;

        }

        public void satilan()
        {
            
            MySqlCommand cmd2 = new MySqlCommand("insert into satilanlar (Ad,Model,Adet) values ('" + ad + "','" + model + "','" + stok + "');", con);
            MySqlDataReader reader1 = cmd2.ExecuteReader();
            while (reader1.Read())
            {

            }
            reader1.Close();
            cmd2.Dispose();
           
        }



        



    }
}
