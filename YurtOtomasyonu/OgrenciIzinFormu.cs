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
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Veliler", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["VeliNo"]);

            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * From IzinTablo", baglanti);
            SqlDataReader oku = komut2.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["IzinNo"].ToString();
                ekle.SubItems.Add(oku["VeliNo"].ToString());
                ekle.SubItems.Add(oku["IzinSebebi"].ToString());
                ekle.SubItems.Add(oku["IzinCikisTarihi"].ToString());
                ekle.SubItems.Add(oku["IzinDonusTarihi"].ToString());
                ekle.SubItems.Add(oku["GittigiYer"].ToString());
                listView1.Items.Add(ekle);

            }
            baglanti.Close();

        }
        private void OgrenciIzinFormu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("sp_OgrenciIzin", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@VeliNo", comboBox1.Text);
            komut.Parameters.AddWithValue("@IzinSebebi", textBox3.Text);
            komut.Parameters.AddWithValue("@GittigiYer", textBox4.Text);
            komut.Parameters.AddWithValue("@IzinCikisTarihi", kayitTarih.Value.ToString("M/d/y"));
            komut.Parameters.AddWithValue("@IzinDonusTarihi", dateTimePicker1.Value.ToString("M/d/y"));
            komut.ExecuteNonQuery();
            listView1.Items.Clear();

            SqlCommand komut2 = new SqlCommand("Select * From IzinTablo", baglanti);
            SqlDataReader oku = komut2.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["IzinNo"].ToString();
                ekle.SubItems.Add(oku["VeliNo"].ToString());
                ekle.SubItems.Add(oku["IzinSebebi"].ToString());
                ekle.SubItems.Add(oku["IzinCikisTarihi"].ToString());
                ekle.SubItems.Add(oku["IzinDonusTarihi"].ToString());
                ekle.SubItems.Add(oku["GittigiYer"].ToString());
                listView1.Items.Add(ekle);
                baglanti.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

            }
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

            string No = comboBox1.Text;
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select VeliAd from Veliler where VeliNo='" + No + "'", baglanti);
            cmd.Parameters.AddWithValue("VeliAd", "string");
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["VeliAd"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("Select OgrenciTcNo from Veliler where VeliNo='" + No + "'", baglanti);
            cmd2.Parameters.AddWithValue("OgrenciTcNo", "string");
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                textBox2.Text = dr2["OgrenciTcNo"].ToString();
            }
            baglanti.Close();
        }

        
    }
}
