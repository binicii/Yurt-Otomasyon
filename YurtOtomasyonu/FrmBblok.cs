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
    public partial class FrmBblok : Form
    {
        public FrmBblok()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HMA2FOJ;Initial Catalog=YurtOtomasyonu;Integrated Security=True");

        private void FrmBblok_Load(object sender, EventArgs e)
        {

        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            try
            {

                baglanti.Open();
                SqlCommand komutkaydet = new SqlCommand("insert into B_Blok_Stok (yatak,masa,sandalye,dolap,komodin,Bblok_id) values(@k1,@k2,@k3,@k4,@k5,k6)", baglanti);
                komutkaydet.Parameters.AddWithValue("@k1", TxtYatakSayisi.Text);
                komutkaydet.Parameters.AddWithValue("@k2", TxtMasaSayisi.Text);
                komutkaydet.Parameters.AddWithValue("@k3", TxtSandalyeSayisi.Text);
                komutkaydet.Parameters.AddWithValue("@k4", TxtDolapSayisi.Text);
                komutkaydet.Parameters.AddWithValue("@k5", TxtKomodinSayisi.Text);
                komutkaydet.Parameters.AddWithValue("@k6", Txtbblokid.Text);

                komutkaydet.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Gerçekleşmiştir");
            }
            catch (Exception)
            {

                MessageBox.Show("Hata!!! Tekrar Deneyiniz");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update B_Blok_Stok set yatak=@k1,masa=@k2,sandalye=@k3,dolap=@k4,komodin=@k5 where Bblok_id=@k6", baglanti);
                komut.Parameters.AddWithValue("@k1", TxtYatakSayisi.Text);
                komut.Parameters.AddWithValue("@k2", TxtMasaSayisi.Text);
                komut.Parameters.AddWithValue("@k3", TxtSandalyeSayisi.Text);
                komut.Parameters.AddWithValue("@k4", TxtDolapSayisi.Text);
                komut.Parameters.AddWithValue("@k5", TxtKomodinSayisi.Text);
                komut.Parameters.AddWithValue("@k6", Txtbblokid.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarıyla Güncellendi");
            }
            catch (Exception)
            {

                MessageBox.Show("HATA!!!!! ");
            }
        }
    }
    }
}
