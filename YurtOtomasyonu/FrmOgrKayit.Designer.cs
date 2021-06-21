
namespace YurtOtomasyonu
{
    partial class OgrenciForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciForm));
            this.TxtAd = new System.Windows.Forms.Label();
            this.TxtOgrAd = new System.Windows.Forms.TextBox();
            this.TxtOgrSoyad = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.Label();
            this.TxtOgrTC = new System.Windows.Forms.Label();
            this.MsbOgrTC = new System.Windows.Forms.MaskedTextBox();
            this.MskOgrTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtOgrTelefon = new System.Windows.Forms.Label();
            this.MsbOgrDogumt = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtOgrBolum = new System.Windows.Forms.Label();
            this.CmbOgrBolum = new System.Windows.Forms.ComboBox();
            this.TxtMail = new System.Windows.Forms.Label();
            this.TxtOgrMail = new System.Windows.Forms.TextBox();
            this.CmbOgrodaNo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtVeliAdSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MskVeliTel = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RcbOgrAdres = new System.Windows.Forms.RichTextBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtAd
            // 
            this.TxtAd.AutoSize = true;
            this.TxtAd.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.Location = new System.Drawing.Point(84, 9);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(112, 23);
            this.TxtAd.TabIndex = 0;
            this.TxtAd.Text = "Öğrenci Ad:";
            this.TxtAd.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtOgrAd
            // 
            this.TxtOgrAd.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TxtOgrAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrAd.Location = new System.Drawing.Point(222, 9);
            this.TxtOgrAd.Name = "TxtOgrAd";
            this.TxtOgrAd.Size = new System.Drawing.Size(246, 30);
            this.TxtOgrAd.TabIndex = 1;
            // 
            // TxtOgrSoyad
            // 
            this.TxtOgrSoyad.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TxtOgrSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrSoyad.Location = new System.Drawing.Point(222, 57);
            this.TxtOgrSoyad.Name = "TxtOgrSoyad";
            this.TxtOgrSoyad.Size = new System.Drawing.Size(246, 30);
            this.TxtOgrSoyad.TabIndex = 3;
            this.TxtOgrSoyad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.AutoSize = true;
            this.TxtSoyad.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoyad.Location = new System.Drawing.Point(57, 57);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(139, 23);
            this.TxtSoyad.TabIndex = 2;
            this.TxtSoyad.Text = "Öğrenci Soyad:";
            this.TxtSoyad.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TxtOgrTC
            // 
            this.TxtOgrTC.AutoSize = true;
            this.TxtOgrTC.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrTC.Location = new System.Drawing.Point(156, 98);
            this.TxtOgrTC.Name = "TxtOgrTC";
            this.TxtOgrTC.Size = new System.Drawing.Size(40, 23);
            this.TxtOgrTC.TabIndex = 4;
            this.TxtOgrTC.Text = "TC:";
            this.TxtOgrTC.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // MsbOgrTC
            // 
            this.MsbOgrTC.BackColor = System.Drawing.SystemColors.MenuBar;
            this.MsbOgrTC.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MsbOgrTC.Location = new System.Drawing.Point(222, 99);
            this.MsbOgrTC.Mask = "00000000000";
            this.MsbOgrTC.Name = "MsbOgrTC";
            this.MsbOgrTC.Size = new System.Drawing.Size(246, 30);
            this.MsbOgrTC.TabIndex = 5;
            this.MsbOgrTC.ValidatingType = typeof(int);
            // 
            // MskOgrTelefon
            // 
            this.MskOgrTelefon.BackColor = System.Drawing.SystemColors.MenuBar;
            this.MskOgrTelefon.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskOgrTelefon.Location = new System.Drawing.Point(222, 145);
            this.MskOgrTelefon.Mask = "(999) 000-0000";
            this.MskOgrTelefon.Name = "MskOgrTelefon";
            this.MskOgrTelefon.Size = new System.Drawing.Size(246, 30);
            this.MskOgrTelefon.TabIndex = 7;
            this.MskOgrTelefon.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MsbOgrTelefon_MaskInputRejected);
            // 
            // TxtOgrTelefon
            // 
            this.TxtOgrTelefon.AutoSize = true;
            this.TxtOgrTelefon.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrTelefon.Location = new System.Drawing.Point(118, 145);
            this.TxtOgrTelefon.Name = "TxtOgrTelefon";
            this.TxtOgrTelefon.Size = new System.Drawing.Size(78, 23);
            this.TxtOgrTelefon.TabIndex = 6;
            this.TxtOgrTelefon.Text = "Telefon:";
            // 
            // MsbOgrDogumt
            // 
            this.MsbOgrDogumt.BackColor = System.Drawing.SystemColors.MenuBar;
            this.MsbOgrDogumt.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MsbOgrDogumt.Location = new System.Drawing.Point(222, 200);
            this.MsbOgrDogumt.Mask = "00/00/0000";
            this.MsbOgrDogumt.Name = "MsbOgrDogumt";
            this.MsbOgrDogumt.Size = new System.Drawing.Size(246, 30);
            this.MsbOgrDogumt.TabIndex = 9;
            this.MsbOgrDogumt.ValidatingType = typeof(System.DateTime);
            this.MsbOgrDogumt.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(66, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Doğum Tarihi";
            this.label1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // TxtOgrBolum
            // 
            this.TxtOgrBolum.AutoSize = true;
            this.TxtOgrBolum.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrBolum.Location = new System.Drawing.Point(53, 255);
            this.TxtOgrBolum.Name = "TxtOgrBolum";
            this.TxtOgrBolum.Size = new System.Drawing.Size(143, 23);
            this.TxtOgrBolum.TabIndex = 10;
            this.TxtOgrBolum.Text = "Öğrenci Bölüm:";
            // 
            // CmbOgrBolum
            // 
            this.CmbOgrBolum.BackColor = System.Drawing.SystemColors.MenuBar;
            this.CmbOgrBolum.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbOgrBolum.FormattingEnabled = true;
            this.CmbOgrBolum.Location = new System.Drawing.Point(222, 254);
            this.CmbOgrBolum.Name = "CmbOgrBolum";
            this.CmbOgrBolum.Size = new System.Drawing.Size(246, 32);
            this.CmbOgrBolum.TabIndex = 11;
            this.CmbOgrBolum.SelectedIndexChanged += new System.EventHandler(this.CmbOgrBolum_SelectedIndexChanged);
            // 
            // TxtMail
            // 
            this.TxtMail.AutoSize = true;
            this.TxtMail.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMail.Location = new System.Drawing.Point(141, 312);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(55, 23);
            this.TxtMail.TabIndex = 12;
            this.TxtMail.Text = "Mail:";
            // 
            // TxtOgrMail
            // 
            this.TxtOgrMail.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TxtOgrMail.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrMail.Location = new System.Drawing.Point(222, 305);
            this.TxtOgrMail.Name = "TxtOgrMail";
            this.TxtOgrMail.Size = new System.Drawing.Size(246, 30);
            this.TxtOgrMail.TabIndex = 13;
            // 
            // CmbOgrodaNo
            // 
            this.CmbOgrodaNo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.CmbOgrodaNo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbOgrodaNo.FormattingEnabled = true;
            this.CmbOgrodaNo.Location = new System.Drawing.Point(222, 349);
            this.CmbOgrodaNo.Name = "CmbOgrodaNo";
            this.CmbOgrodaNo.Size = new System.Drawing.Size(246, 32);
            this.CmbOgrodaNo.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(115, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Oda No:";
            // 
            // TxtVeliAdSoyad
            // 
            this.TxtVeliAdSoyad.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TxtVeliAdSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtVeliAdSoyad.Location = new System.Drawing.Point(222, 401);
            this.TxtVeliAdSoyad.Name = "TxtVeliAdSoyad";
            this.TxtVeliAdSoyad.Size = new System.Drawing.Size(246, 30);
            this.TxtVeliAdSoyad.TabIndex = 17;
            this.TxtVeliAdSoyad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(62, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Veli Ad Soyad:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // MskVeliTel
            // 
            this.MskVeliTel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.MskVeliTel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskVeliTel.Location = new System.Drawing.Point(222, 444);
            this.MskVeliTel.Mask = "(999) 000-0000";
            this.MskVeliTel.Name = "MskVeliTel";
            this.MskVeliTel.Size = new System.Drawing.Size(246, 30);
            this.MskVeliTel.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(80, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Veli Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(131, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Adres:";
            // 
            // RcbOgrAdres
            // 
            this.RcbOgrAdres.BackColor = System.Drawing.SystemColors.MenuBar;
            this.RcbOgrAdres.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RcbOgrAdres.Location = new System.Drawing.Point(222, 499);
            this.RcbOgrAdres.Name = "RcbOgrAdres";
            this.RcbOgrAdres.Size = new System.Drawing.Size(246, 76);
            this.RcbOgrAdres.TabIndex = 21;
            this.RcbOgrAdres.Text = "";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Location = new System.Drawing.Point(247, 594);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(137, 48);
            this.BtnKaydet.TabIndex = 22;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 509);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // OgrenciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(557, 654);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.RcbOgrAdres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MskVeliTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtVeliAdSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbOgrodaNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtOgrMail);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.CmbOgrBolum);
            this.Controls.Add(this.TxtOgrBolum);
            this.Controls.Add(this.MsbOgrDogumt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MskOgrTelefon);
            this.Controls.Add(this.TxtOgrTelefon);
            this.Controls.Add(this.MsbOgrTC);
            this.Controls.Add(this.TxtOgrTC);
            this.Controls.Add(this.TxtOgrSoyad);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtOgrAd);
            this.Controls.Add(this.TxtAd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OgrenciForm";
            this.Text = "Öğrenci Kayıt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TxtAd;
        private System.Windows.Forms.TextBox TxtOgrAd;
        private System.Windows.Forms.TextBox TxtOgrSoyad;
        private System.Windows.Forms.Label TxtSoyad;
        private System.Windows.Forms.Label TxtOgrTC;
        private System.Windows.Forms.MaskedTextBox MsbOgrTC;
        private System.Windows.Forms.MaskedTextBox MskOgrTelefon;
        private System.Windows.Forms.Label TxtOgrTelefon;
        private System.Windows.Forms.MaskedTextBox MsbOgrDogumt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TxtOgrBolum;
        private System.Windows.Forms.ComboBox CmbOgrBolum;
        private System.Windows.Forms.Label TxtMail;
        private System.Windows.Forms.TextBox TxtOgrMail;
        private System.Windows.Forms.ComboBox CmbOgrodaNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtVeliAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MskVeliTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox RcbOgrAdres;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label label6;
    }
}

