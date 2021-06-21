
namespace YurtOtomasyonu
{
    partial class FrmOgrDuzenle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrDuzenle));
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.RcbOgrAdres = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MskVeliTel = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtVeliAdSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbOgrodaNo = new System.Windows.Forms.ComboBox();
            this.odalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet7 = new YurtOtomasyonu.YurtOtomasyonuDataSet7();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtOgrMail = new System.Windows.Forms.TextBox();
            this.TxtMail = new System.Windows.Forms.Label();
            this.TxtOgrBolum = new System.Windows.Forms.Label();
            this.MsbOgrDogumt = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MskOgrTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtOgrTelefon = new System.Windows.Forms.Label();
            this.MsbOgrTC = new System.Windows.Forms.MaskedTextBox();
            this.TxtOgrTC = new System.Windows.Forms.Label();
            this.TxtOgrSoyad = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.Label();
            this.TxtOgrAd = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.Label();
            this.TxtOgrid = new System.Windows.Forms.TextBox();
            this.CmbOgrBolum = new System.Windows.Forms.ComboBox();
            this.bolumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet6 = new YurtOtomasyonu.YurtOtomasyonuDataSet6();
            this.bolumlerTableAdapter = new YurtOtomasyonu.YurtOtomasyonuDataSet6TableAdapters.BolumlerTableAdapter();
            this.odalarTableAdapter = new YurtOtomasyonu.YurtOtomasyonuDataSet7TableAdapters.OdalarTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F);
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 551);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 47;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Location = new System.Drawing.Point(130, 634);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(137, 48);
            this.BtnGuncelle.TabIndex = 46;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // RcbOgrAdres
            // 
            this.RcbOgrAdres.BackColor = System.Drawing.SystemColors.MenuBar;
            this.RcbOgrAdres.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RcbOgrAdres.Location = new System.Drawing.Point(207, 541);
            this.RcbOgrAdres.Name = "RcbOgrAdres";
            this.RcbOgrAdres.Size = new System.Drawing.Size(246, 76);
            this.RcbOgrAdres.TabIndex = 45;
            this.RcbOgrAdres.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(116, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 44;
            this.label5.Text = "Adres:";
            // 
            // MskVeliTel
            // 
            this.MskVeliTel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.MskVeliTel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskVeliTel.Location = new System.Drawing.Point(207, 486);
            this.MskVeliTel.Mask = "(999) 000-0000";
            this.MskVeliTel.Name = "MskVeliTel";
            this.MskVeliTel.Size = new System.Drawing.Size(246, 30);
            this.MskVeliTel.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(65, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 42;
            this.label4.Text = "Veli Telefon:";
            // 
            // TxtVeliAdSoyad
            // 
            this.TxtVeliAdSoyad.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TxtVeliAdSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtVeliAdSoyad.Location = new System.Drawing.Point(207, 443);
            this.TxtVeliAdSoyad.Name = "TxtVeliAdSoyad";
            this.TxtVeliAdSoyad.Size = new System.Drawing.Size(246, 30);
            this.TxtVeliAdSoyad.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "Veli Ad Soyad:";
            // 
            // CmbOgrodaNo
            // 
            this.CmbOgrodaNo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.CmbOgrodaNo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.odalarBindingSource, "OdaNo", true));
            this.CmbOgrodaNo.DataSource = this.odalarBindingSource;
            this.CmbOgrodaNo.DisplayMember = "OdaNo";
            this.CmbOgrodaNo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbOgrodaNo.FormattingEnabled = true;
            this.CmbOgrodaNo.Location = new System.Drawing.Point(207, 391);
            this.CmbOgrodaNo.Name = "CmbOgrodaNo";
            this.CmbOgrodaNo.Size = new System.Drawing.Size(246, 32);
            this.CmbOgrodaNo.TabIndex = 39;
            this.CmbOgrodaNo.ValueMember = "OdaNo";
            // 
            // odalarBindingSource
            // 
            this.odalarBindingSource.DataMember = "Odalar";
            this.odalarBindingSource.DataSource = this.yurtOtomasyonuDataSet7;
            // 
            // yurtOtomasyonuDataSet7
            // 
            this.yurtOtomasyonuDataSet7.DataSetName = "YurtOtomasyonuDataSet7";
            this.yurtOtomasyonuDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(100, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 38;
            this.label2.Text = "Oda No:";
            // 
            // TxtOgrMail
            // 
            this.TxtOgrMail.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TxtOgrMail.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrMail.Location = new System.Drawing.Point(207, 347);
            this.TxtOgrMail.Name = "TxtOgrMail";
            this.TxtOgrMail.Size = new System.Drawing.Size(246, 30);
            this.TxtOgrMail.TabIndex = 37;
            // 
            // TxtMail
            // 
            this.TxtMail.AutoSize = true;
            this.TxtMail.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMail.Location = new System.Drawing.Point(126, 354);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(55, 23);
            this.TxtMail.TabIndex = 36;
            this.TxtMail.Text = "Mail:";
            // 
            // TxtOgrBolum
            // 
            this.TxtOgrBolum.AutoSize = true;
            this.TxtOgrBolum.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrBolum.Location = new System.Drawing.Point(38, 297);
            this.TxtOgrBolum.Name = "TxtOgrBolum";
            this.TxtOgrBolum.Size = new System.Drawing.Size(143, 23);
            this.TxtOgrBolum.TabIndex = 34;
            this.TxtOgrBolum.Text = "Öğrenci Bölüm:";
            // 
            // MsbOgrDogumt
            // 
            this.MsbOgrDogumt.BackColor = System.Drawing.SystemColors.MenuBar;
            this.MsbOgrDogumt.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MsbOgrDogumt.Location = new System.Drawing.Point(207, 242);
            this.MsbOgrDogumt.Mask = "00/00/0000";
            this.MsbOgrDogumt.Name = "MsbOgrDogumt";
            this.MsbOgrDogumt.Size = new System.Drawing.Size(246, 30);
            this.MsbOgrDogumt.TabIndex = 33;
            this.MsbOgrDogumt.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(51, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 23);
            this.label7.TabIndex = 32;
            this.label7.Text = "Doğum Tarihi";
            // 
            // MskOgrTelefon
            // 
            this.MskOgrTelefon.BackColor = System.Drawing.SystemColors.MenuBar;
            this.MskOgrTelefon.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskOgrTelefon.Location = new System.Drawing.Point(207, 187);
            this.MskOgrTelefon.Mask = "(999) 000-0000";
            this.MskOgrTelefon.Name = "MskOgrTelefon";
            this.MskOgrTelefon.Size = new System.Drawing.Size(246, 30);
            this.MskOgrTelefon.TabIndex = 31;
            // 
            // TxtOgrTelefon
            // 
            this.TxtOgrTelefon.AutoSize = true;
            this.TxtOgrTelefon.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrTelefon.Location = new System.Drawing.Point(103, 187);
            this.TxtOgrTelefon.Name = "TxtOgrTelefon";
            this.TxtOgrTelefon.Size = new System.Drawing.Size(78, 23);
            this.TxtOgrTelefon.TabIndex = 30;
            this.TxtOgrTelefon.Text = "Telefon:";
            // 
            // MsbOgrTC
            // 
            this.MsbOgrTC.BackColor = System.Drawing.SystemColors.MenuBar;
            this.MsbOgrTC.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MsbOgrTC.Location = new System.Drawing.Point(207, 141);
            this.MsbOgrTC.Mask = "00000000000";
            this.MsbOgrTC.Name = "MsbOgrTC";
            this.MsbOgrTC.Size = new System.Drawing.Size(246, 30);
            this.MsbOgrTC.TabIndex = 29;
            this.MsbOgrTC.ValidatingType = typeof(int);
            // 
            // TxtOgrTC
            // 
            this.TxtOgrTC.AutoSize = true;
            this.TxtOgrTC.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrTC.Location = new System.Drawing.Point(141, 140);
            this.TxtOgrTC.Name = "TxtOgrTC";
            this.TxtOgrTC.Size = new System.Drawing.Size(40, 23);
            this.TxtOgrTC.TabIndex = 28;
            this.TxtOgrTC.Text = "TC:";
            // 
            // TxtOgrSoyad
            // 
            this.TxtOgrSoyad.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TxtOgrSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrSoyad.Location = new System.Drawing.Point(207, 99);
            this.TxtOgrSoyad.Name = "TxtOgrSoyad";
            this.TxtOgrSoyad.Size = new System.Drawing.Size(246, 30);
            this.TxtOgrSoyad.TabIndex = 27;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.AutoSize = true;
            this.TxtSoyad.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoyad.Location = new System.Drawing.Point(42, 99);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(139, 23);
            this.TxtSoyad.TabIndex = 26;
            this.TxtSoyad.Text = "Öğrenci Soyad:";
            // 
            // TxtOgrAd
            // 
            this.TxtOgrAd.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TxtOgrAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrAd.Location = new System.Drawing.Point(207, 51);
            this.TxtOgrAd.Name = "TxtOgrAd";
            this.TxtOgrAd.Size = new System.Drawing.Size(246, 30);
            this.TxtOgrAd.TabIndex = 25;
            // 
            // TxtAd
            // 
            this.TxtAd.AutoSize = true;
            this.TxtAd.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.Location = new System.Drawing.Point(69, 51);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(112, 23);
            this.TxtAd.TabIndex = 24;
            this.TxtAd.Text = "Öğrenci Ad:";
            // 
            // TxtOgrid
            // 
            this.TxtOgrid.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TxtOgrid.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrid.Location = new System.Drawing.Point(207, 9);
            this.TxtOgrid.Name = "TxtOgrid";
            this.TxtOgrid.Size = new System.Drawing.Size(246, 30);
            this.TxtOgrid.TabIndex = 48;
            // 
            // CmbOgrBolum
            // 
            this.CmbOgrBolum.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bolumlerBindingSource, "BolumAd", true));
            this.CmbOgrBolum.DataSource = this.bolumlerBindingSource;
            this.CmbOgrBolum.DisplayMember = "BolumAd";
            this.CmbOgrBolum.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbOgrBolum.FormattingEnabled = true;
            this.CmbOgrBolum.Location = new System.Drawing.Point(207, 297);
            this.CmbOgrBolum.Name = "CmbOgrBolum";
            this.CmbOgrBolum.Size = new System.Drawing.Size(246, 32);
            this.CmbOgrBolum.TabIndex = 49;
            this.CmbOgrBolum.ValueMember = "BolumAd";
            // 
            // bolumlerBindingSource
            // 
            this.bolumlerBindingSource.DataMember = "Bolumler";
            this.bolumlerBindingSource.DataSource = this.yurtOtomasyonuDataSet6;
            // 
            // yurtOtomasyonuDataSet6
            // 
            this.yurtOtomasyonuDataSet6.DataSetName = "YurtOtomasyonuDataSet6";
            this.yurtOtomasyonuDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumlerTableAdapter
            // 
            this.bolumlerTableAdapter.ClearBeforeFill = true;
            // 
            // odalarTableAdapter
            // 
            this.odalarTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(291, 634);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 48);
            this.button1.TabIndex = 50;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmOgrDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(555, 694);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CmbOgrBolum);
            this.Controls.Add(this.TxtOgrid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnGuncelle);
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
            this.Controls.Add(this.TxtOgrBolum);
            this.Controls.Add(this.MsbOgrDogumt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MskOgrTelefon);
            this.Controls.Add(this.TxtOgrTelefon);
            this.Controls.Add(this.MsbOgrTC);
            this.Controls.Add(this.TxtOgrTC);
            this.Controls.Add(this.TxtOgrSoyad);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtOgrAd);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOgrDuzenle";
            this.Text = "Öğrenci Düzenle";
            this.Load += new System.EventHandler(this.FrmOgrDuzenle_Load);
            this.Click += new System.EventHandler(this.FrmOgrDuzenle_Click);
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.RichTextBox RcbOgrAdres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox MskVeliTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtVeliAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbOgrodaNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtOgrMail;
        private System.Windows.Forms.Label TxtMail;
        private System.Windows.Forms.Label TxtOgrBolum;
        private System.Windows.Forms.MaskedTextBox MsbOgrDogumt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox MskOgrTelefon;
        private System.Windows.Forms.Label TxtOgrTelefon;
        private System.Windows.Forms.MaskedTextBox MsbOgrTC;
        private System.Windows.Forms.Label TxtOgrTC;
        private System.Windows.Forms.TextBox TxtOgrSoyad;
        private System.Windows.Forms.Label TxtSoyad;
        private System.Windows.Forms.TextBox TxtOgrAd;
        private System.Windows.Forms.Label TxtAd;
        private System.Windows.Forms.TextBox TxtOgrid;
        private System.Windows.Forms.ComboBox CmbOgrBolum;
        private YurtOtomasyonuDataSet6 yurtOtomasyonuDataSet6;
        private System.Windows.Forms.BindingSource bolumlerBindingSource;
        private YurtOtomasyonuDataSet6TableAdapters.BolumlerTableAdapter bolumlerTableAdapter;
        private YurtOtomasyonuDataSet7 yurtOtomasyonuDataSet7;
        private System.Windows.Forms.BindingSource odalarBindingSource;
        private YurtOtomasyonuDataSet7TableAdapters.OdalarTableAdapter odalarTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}