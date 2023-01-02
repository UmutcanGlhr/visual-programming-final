using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknoMarkt
{
    public partial class teknomarkt_Anasayfa : Form
    {
        
        public teknomarkt_Anasayfa()
        {
            InitializeComponent();
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {

            this.Hide();
            
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void teknomarkt_Anasayfa_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            Mağaza mgz = new Mağaza();
            this.Hide();
            mgz.ShowDialog();
            this.Close();
            
        }

        private void ıconButton4_Click(object sender, EventArgs e)
        {
            UrunEkle urn = new UrunEkle();
            
            urn.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Satis sts = new Satis();
            sts.ShowDialog();
        }
    }  
}
