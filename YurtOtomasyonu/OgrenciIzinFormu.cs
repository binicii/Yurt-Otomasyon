using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtOtomasyonu
{
    public partial class OgrenciIzinFormu : Form
    {
        public OgrenciIzinFormu()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HMA2FOJ;Initial Catalog=YurtOtomasyonu;Integrated Security=True");

        private void OgrenciIzinFormu_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            OgrenciIzinFormu f1 = new OgrenciIzinFormu();
            f1.Close();
            OgrenciIzinFormu f2 = new OgrenciIzinFormu();
            f2.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
