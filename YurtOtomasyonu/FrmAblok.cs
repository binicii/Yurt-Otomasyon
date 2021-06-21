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

            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HMA2FOJ;Initial Catalog=YurtOtomasyonu;Integrated Security=True");
        }

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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komutsil = new SqlCommand("delete from A_Blok_Stok where Ablok_id=@k6", baglanti);
                komutsil.Parameters.AddWithValue("@k6", TxtAblokid.Text);
                komutsil.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
            }
            catch (Exception)
            {

                MessageBox.Show("Hata!!! Tekrar Deneyiniz");
            }
        }

    }
    }
}
