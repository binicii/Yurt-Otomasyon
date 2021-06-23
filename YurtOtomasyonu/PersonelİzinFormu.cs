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
    public partial class PersonelİzinFormu : Form
    {
        public PersonelİzinFormu()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HMA2FOJ;Initial Catalog=YurtOtomasyonu;Integrated Security=True");

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string No = comboBox1.Text;
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select Ad from Personeller where PersonelNo='" + No + "'", baglanti);
            cmd.Parameters.AddWithValue("Ad", "string");
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["Ad"].ToString();
            }
            baglanti.Close();
        }

        private void PersonelİzinFormu_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Personeller", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["PersonelNo"]);

            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * From PersonelIzin", baglanti);
            SqlDataReader oku = komut2.ExecuteReader();
            ListViewItem ekle = new ListViewItem();
            ekle.Text = oku["IzinId"].ToString();
            ekle.SubItems.Add(oku["PersonelNo"].ToString());
            ekle.SubItems.Add(oku["IzinSebebi"].ToString());
            ekle.SubItems.Add(oku["IzinCikisTarihi"].ToString());
            ekle.SubItems.Add(oku["IzinDonusTarihi"].ToString());
            listView1.Items.Add(ekle);
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonelİzinFormu f1 = new PersonelİzinFormu();
            f1.Close();
            PersonelİzinFormu f2 = new PersonelİzinFormu();
            f2.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("sp_IzinPersonel", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@PersonelNo", comboBox1.Text);
            komut.Parameters.AddWithValue("@IzinSebebi", textBox3.Text);
            komut.Parameters.AddWithValue("@IzinCikisTarihi", kayitTarih.Value.ToString("M/d/y"));
            komut.Parameters.AddWithValue("@IzinDonusTarihi", dateTimePicker1.Value.ToString("M/d/y"));
            komut.ExecuteNonQuery();
            listView1.Items.Clear();
            SqlCommand komut2 = new SqlCommand("Select * From PersonelIzin", baglanti);
            SqlDataReader oku = komut2.ExecuteReader();
            baglanti.Close();
        }
    }
}
