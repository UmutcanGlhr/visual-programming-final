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
using System.IO;
namespace TeknoMarkt
{
    public partial class GirişEkrani : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=teknomarkt;Uid=root;Pwd='mysql1234';");
        
        
        public GirişEkrani()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from kullanici where kullanici_adi = '" + textBox1.Text + "' AND Şifre = '" + textBox2.Text + "'", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                

                if (textBox1.Text==""&&textBox2.Text=="")
                {
                    MessageBox.Show("Boş alanları doldurunuz !!!");
                }
                else
                {
                    if (reader.Read())
                    {


                        Profilim prf = new Profilim();
                        this.Hide();
                        prf.prfal(textBox1.Text);
                        prf.ShowDialog();
                        this.Close();


                        

                    }
                    else
                    {
                        MessageBox.Show("Hatalı");
                    }
                   

                }
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                reader.Close();
                cmd.Dispose();
                con.Close();




            }
            catch (Exception ex )
            {

               
            }



        }
       
        
    

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            KayıtoOl kayıtol = new KayıtoOl();
            kayıtol.Show();

        }


       










    }
}
