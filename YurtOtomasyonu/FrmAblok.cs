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
    public partial class FrmAblok: Form
    {
        public FrmAblok()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HMA2FOJ;Initial Catalog=YurtOtomasyonu;Integrated Security=True");

        private void FrmAblok_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet15.A_Blok_Stok' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.a_Blok_StokTableAdapter.Fill(this.yurtOtomasyonuDataSet15.A_Blok_Stok);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutkaydet = new SqlCommand("insert into A_Blok_Stok (yatak,masa,sandalye,dolap,komodin,Ablok_id) values(@k1,@k2,@k3,@k4,@k5,k6)", baglanti);
            komutkaydet.Parameters.AddWithValue("@k1", TxtYatakSayisi.Text);
            komutkaydet.Parameters.AddWithValue("@k2", TxtMasaSayisi.Text);
            komutkaydet.Parameters.AddWithValue("@k3", TxtSandalyeSayisi.Text);
            komutkaydet.Parameters.AddWithValue("@k4", TxtDolapSayisi.Text);
            komutkaydet.Parameters.AddWithValue("@k5", TxtKomodinSayisi.Text);
            komutkaydet.Parameters.AddWithValue("@k6", TxtAblokid.Text);

            komutkaydet.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
