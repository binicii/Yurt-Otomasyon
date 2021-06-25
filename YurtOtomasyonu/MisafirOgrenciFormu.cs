﻿using System;
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

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}