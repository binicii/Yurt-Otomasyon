private void Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("delete from B_Blok_Stok where Bblok_id=@k6", baglanti);
            komutsil.Parameters.AddWithValue("@k6", TxtBblokid.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi");

            
        }