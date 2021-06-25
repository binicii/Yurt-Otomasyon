using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtOtomasyonu
{
    public partial class MisafirOgrenciFormu : Form
    {
        public MisafirOgrenciFormu()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HMA2FOJ;Initial Catalog=YurtOtomasyonu;Integrated Security=True");

        private void MisafirOgrenciFormu_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select BolumAd From Bolumler", baglanti); //bolumler tablosundakı BolumAd kısmındakı verılerı cektık.
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                CmbOgrBolum.Items.Add(oku[0].ToString());
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select OdaNo From Odalar where OdaKapasite != OdaAktif", baglanti); //where sorgusu ile boş odaların tespitini yaptık,OdaKapasite ile OdaAktif eşitse oda doludur
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                CmbOgrodaNo.Items.Add(oku2[0].ToString());
            }
            baglanti.Close();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                baglanti.Open();
                SqlCommand komutkaydet = new SqlCommand("insert into Ogrenci (OgrAd,OgrSoyad,OgrTC,OgrTelefon,OgrDogum,OgrBolum,OgrMail,OgrOda,OgrVeliAdSoyad,OgrVeliAdres,OgrVeliTelefon) values(@Ad,@Soyad,@TC,@Telefon,@Dogum,@Bolum,@Mail,@Oda,@VeliAdSoyad,@VeliAdres,@VeliTelefon)", baglanti);
                komutkaydet.Parameters.AddWithValue("@Ad", TxtOgrAd.Text);
                komutkaydet.Parameters.AddWithValue("@Soyad", TxtOgrSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@TC", MsbOgrTC.Text);
                komutkaydet.Parameters.AddWithValue("@Telefon", MskOgrTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@Dogum", MsbOgrDogumt.Text);
                komutkaydet.Parameters.AddWithValue("@Bolum", CmbOgrBolum.Text);
                komutkaydet.Parameters.AddWithValue("@Mail", TxtOgrMail.Text);
                komutkaydet.Parameters.AddWithValue("@Oda", CmbOgrodaNo.Text);
                komutkaydet.Parameters.AddWithValue("@VeliAdSoyad", MsbGirisTarihi.Text);
                komutkaydet.Parameters.AddWithValue("@VeliAdres", MsbCikisT.Text);

                komutkaydet.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Gerçekleşmiştir");
            }
            catch (Exception)
            {
                MessageBox.Show("HATA!!! Lütfen Tekrar Deneyin");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
