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
            Profilim prf = new Profilim();
            prf.kapa();

            this.Hide();
            GirişEkrani grs = new GirişEkrani();
            grs.ShowDialog();
            this.Close();
        }
        
        private void teknomarkt_Anasayfa_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }  
}
