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
    public partial class Satis : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=teknomarkt;Uid=root;Pwd='mysql1234';");
        public Satis()
        {
            InitializeComponent();
        }

        private void Satis_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlDataAdapter sqlda = new MySqlDataAdapter("select * from satilanlar", con);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            con.Close();
        }
    }
}
