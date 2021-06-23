
namespace YurtOtomasyonu
{
    partial class FrmAblok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAblok));
            this.a_Blok_StokTableAdapter = new YurtOtomasyonu.YurtOtomasyonuDataSet15TableAdapters.A_Blok_StokTableAdapter();
            this.yurtOtomasyonuDataSet15 = new YurtOtomasyonu.YurtOtomasyonuDataSet15();
            this.aBlokStokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.Guncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDolapSayisi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtMasaSayisi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtKomodinSayisi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSandalyeSayisi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtYatakSayisi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAblokid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ablokidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dolapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.komodinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sandalyeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yatakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Kaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBlokStokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // a_Blok_StokTableAdapter
            // 
            this.a_Blok_StokTableAdapter.ClearBeforeFill = true;
            // 
            // yurtOtomasyonuDataSet15
            // 
            this.yurtOtomasyonuDataSet15.DataSetName = "YurtOtomasyonuDataSet15";
            this.yurtOtomasyonuDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aBlokStokBindingSource
            // 
            this.aBlokStokBindingSource.DataMember = "A_Blok_Stok";
            this.aBlokStokBindingSource.DataSource = this.yurtOtomasyonuDataSet15;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(146, 416);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 40);
            this.button3.TabIndex = 15;
            this.button3.Text = "SİL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Guncelle
            // 
            this.Guncelle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Guncelle.Location = new System.Drawing.Point(279, 416);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(136, 40);
            this.Guncelle.TabIndex = 14;
            this.Guncelle.Text = "GÜNCELLE";
            this.Guncelle.UseVisualStyleBackColor = true;
            this.Guncelle.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(38, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Dolap Sayısı:";
            // 
            // TxtDolapSayisi
            // 
            this.TxtDolapSayisi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDolapSayisi.Location = new System.Drawing.Point(187, 340);
            this.TxtDolapSayisi.Name = "TxtDolapSayisi";
            this.TxtDolapSayisi.Size = new System.Drawing.Size(215, 30);
            this.TxtDolapSayisi.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(43, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Masa Sayısı:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // TxtMasaSayisi
            // 
            this.TxtMasaSayisi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMasaSayisi.Location = new System.Drawing.Point(187, 154);
            this.TxtMasaSayisi.Name = "TxtMasaSayisi";
            this.TxtMasaSayisi.Size = new System.Drawing.Size(215, 30);
            this.TxtMasaSayisi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sandalye Sayısı:";
            // 
            // TxtKomodinSayisi
            // 
            this.TxtKomodinSayisi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKomodinSayisi.Location = new System.Drawing.Point(187, 292);
            this.TxtKomodinSayisi.Name = "TxtKomodinSayisi";
            this.TxtKomodinSayisi.Size = new System.Drawing.Size(215, 30);
            this.TxtKomodinSayisi.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Komodin Sayısı:";
            // 
            // TxtSandalyeSayisi
            // 
            this.TxtSandalyeSayisi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSandalyeSayisi.Location = new System.Drawing.Point(187, 201);
            this.TxtSandalyeSayisi.Name = "TxtSandalyeSayisi";
            this.TxtSandalyeSayisi.Size = new System.Drawing.Size(215, 30);
            this.TxtSandalyeSayisi.TabIndex = 6;
            this.TxtSandalyeSayisi.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(41, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yatak Sayısı:";
            // 
            // TxtYatakSayisi
            // 
            this.TxtYatakSayisi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtYatakSayisi.Location = new System.Drawing.Point(187, 246);
            this.TxtYatakSayisi.Name = "TxtYatakSayisi";
            this.TxtYatakSayisi.Size = new System.Drawing.Size(215, 30);
            this.TxtYatakSayisi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(153, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "A BLOK STOK TAKİBİ";
            // 
            // TxtAblokid
            // 
            this.TxtAblokid.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAblokid.Location = new System.Drawing.Point(187, 109);
            this.TxtAblokid.Name = "TxtAblokid";
            this.TxtAblokid.Size = new System.Drawing.Size(215, 30);
            this.TxtAblokid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(61, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "A Blok ID:";
            // 
            // ablokidDataGridViewTextBoxColumn
            // 
            this.ablokidDataGridViewTextBoxColumn.DataPropertyName = "Ablok_id";
            this.ablokidDataGridViewTextBoxColumn.HeaderText = "Ablok_id";
            this.ablokidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ablokidDataGridViewTextBoxColumn.Name = "ablokidDataGridViewTextBoxColumn";
            this.ablokidDataGridViewTextBoxColumn.ReadOnly = true;
            this.ablokidDataGridViewTextBoxColumn.Width = 125;
            // 
            // dolapDataGridViewTextBoxColumn
            // 
            this.dolapDataGridViewTextBoxColumn.DataPropertyName = "dolap";
            this.dolapDataGridViewTextBoxColumn.HeaderText = "dolap";
            this.dolapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dolapDataGridViewTextBoxColumn.Name = "dolapDataGridViewTextBoxColumn";
            this.dolapDataGridViewTextBoxColumn.Width = 125;
            // 
            // komodinDataGridViewTextBoxColumn
            // 
            this.komodinDataGridViewTextBoxColumn.DataPropertyName = "komodin";
            this.komodinDataGridViewTextBoxColumn.HeaderText = "komodin";
            this.komodinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.komodinDataGridViewTextBoxColumn.Name = "komodinDataGridViewTextBoxColumn";
            this.komodinDataGridViewTextBoxColumn.Width = 125;
            // 
            // sandalyeDataGridViewTextBoxColumn
            // 
            this.sandalyeDataGridViewTextBoxColumn.DataPropertyName = "sandalye";
            this.sandalyeDataGridViewTextBoxColumn.HeaderText = "sandalye";
            this.sandalyeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sandalyeDataGridViewTextBoxColumn.Name = "sandalyeDataGridViewTextBoxColumn";
            this.sandalyeDataGridViewTextBoxColumn.Width = 125;
            // 
            // masaDataGridViewTextBoxColumn
            // 
            this.masaDataGridViewTextBoxColumn.DataPropertyName = "masa";
            this.masaDataGridViewTextBoxColumn.HeaderText = "masa";
            this.masaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.masaDataGridViewTextBoxColumn.Name = "masaDataGridViewTextBoxColumn";
            this.masaDataGridViewTextBoxColumn.Width = 125;
            // 
            // yatakDataGridViewTextBoxColumn
            // 
            this.yatakDataGridViewTextBoxColumn.DataPropertyName = "yatak";
            this.yatakDataGridViewTextBoxColumn.HeaderText = "yatak";
            this.yatakDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yatakDataGridViewTextBoxColumn.Name = "yatakDataGridViewTextBoxColumn";
            this.yatakDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yatakDataGridViewTextBoxColumn,
            this.masaDataGridViewTextBoxColumn,
            this.sandalyeDataGridViewTextBoxColumn,
            this.komodinDataGridViewTextBoxColumn,
            this.dolapDataGridViewTextBoxColumn,
            this.ablokidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aBlokStokBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(456, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(513, 336);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Kaydet
            // 
            this.Kaydet.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kaydet.Location = new System.Drawing.Point(16, 416);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(97, 40);
            this.Kaydet.TabIndex = 17;
            this.Kaydet.Text = "KAYDET";
            this.Kaydet.UseVisualStyleBackColor = true;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // FrmAblok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1027, 493);
            this.Controls.Add(this.Kaydet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Guncelle);
            this.Controls.Add(this.TxtDolapSayisi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtMasaSayisi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtKomodinSayisi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtSandalyeSayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtYatakSayisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtAblokid);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAblok";
            this.Text = "A BLOK STOK TAKİBİ";
            this.Load += new System.EventHandler(this.FrmAblok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBlokStokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private YurtOtomasyonuDataSet15TableAdapters.A_Blok_StokTableAdapter a_Blok_StokTableAdapter;
        private YurtOtomasyonuDataSet15 yurtOtomasyonuDataSet15;
        private System.Windows.Forms.BindingSource aBlokStokBindingSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Guncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtDolapSayisi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtMasaSayisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtKomodinSayisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSandalyeSayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtYatakSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAblokid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ablokidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dolapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn komodinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sandalyeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yatakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Kaydet;
    }
}