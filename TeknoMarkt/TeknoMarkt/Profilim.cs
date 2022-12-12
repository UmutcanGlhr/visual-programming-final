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
    public partial class Profilim : Form
    {

        string name;
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=teknomarkt;Uid=root;Pwd='mysql1234';");
        public Profilim()
        {
            InitializeComponent();
            
        }
     

        private void Profilim_Load(object sender, EventArgs e)
        {

            

            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from kullanici where kullanici_adi='"+name+"'",con);
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                label2.Text = read["Ad"].ToString();
                label3.Text = read["Soyad"].ToString();
                label4.Text = read["kullanici_adi"].ToString();
                label5.Text = read["email"].ToString();
                label6.Text = read["adres"].ToString();
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

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            teknomarkt_Anasayfa anasayfa = new teknomarkt_Anasayfa();
            anasayfa.ShowDialog();
            
        }
        public void kapa()
        {
            this.Close();
        }
    }
}
