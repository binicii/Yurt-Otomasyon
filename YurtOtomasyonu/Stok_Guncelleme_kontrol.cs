private void Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update A_Blok_Stok set yatak=@k1,masa=@k2,sandalye=@k3,dolap=@k4,komodin=@k5 where Ablok_id=@k6", baglanti);
                komut.Parameters.AddWithValue("@k1", TxtYatakSayisi.Text);
                komut.Parameters.AddWithValue("@k2", TxtMasaSayisi.Text);
                komut.Parameters.AddWithValue("@k3", TxtSandalyeSayisi.Text);
                komut.Parameters.AddWithValue("@k4", TxtDolapSayisi.Text);
                komut.Parameters.AddWithValue("@k5", TxtKomodinSayisi.Text);
                komut.Parameters.AddWithValue("@k6", TxtAblokid.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarıyla Güncellendi");
            }
            catch (Exception)
            {

                MessageBox.Show("HATA!!!!! ");
            }
        }