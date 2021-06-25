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
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Ogrenci set OgrAd=@p2,OgrSoyad=@p3,OgrTC=@p4,OgrTelefon=@p5,OgrDogum=@p6,OgrBolum=@p7,OgrMail=@p8,OgrOda=@p9,OgrGirisTarihi=@p10,OgrCikisTarihi=@p11 ", baglanti);
            komut.Parameters.AddWithValue("@p2", TxtOgrAd.Text);
            komut.Parameters.AddWithValue("@p3", TxtOgrSoyad.Text);
            komut.Parameters.AddWithValue("@p4", MsbOgrTC.Text);
            komut.Parameters.AddWithValue("@p5", MskOgrTelefon.Text);
            komut.Parameters.AddWithValue("@p6", MsbOgrDogumt.Text);
            komut.Parameters.AddWithValue("@p7", CmbOgrBolum.Text);
            komut.Parameters.AddWithValue("@p8", TxtOgrMail.Text);
            komut.Parameters.AddWithValue("@p9", CmbOgrodaNo.Text);
            komut.Parameters.AddWithValue("@p10", MsbCikisT.Text);
            komut.Parameters.AddWithValue("@p11", MsbGirisTarihi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
