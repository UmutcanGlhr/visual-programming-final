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
    public partial class Mağaza : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=teknomarkt;Uid=root;Pwd='mysql1234';");
        public Mağaza()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            teknomarkt_Anasayfa ansyfa = new teknomarkt_Anasayfa();
            this.Hide();
            ansyfa.ShowDialog();
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Buzdolabı
            Buzdolabı bzdb = new Buzdolabı();
            this.Hide();
            bzdb.ShowDialog();
            

           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            CamasırMak cms = new CamasırMak();
            this.Hide();
            cms.ShowDialog();
        }
    }
}
