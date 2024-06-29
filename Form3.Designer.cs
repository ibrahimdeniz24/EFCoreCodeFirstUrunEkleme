namespace _13_UrunEklemeOtomasyonu
{
    partial class Form3
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
            cbxKategori = new ComboBox();
            txtUrunAdi = new TextBox();
            nudBirimFiyat = new NumericUpDown();
            btnKaydet = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            listViewProduct = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            btnGeriDon = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nudStokAdeti = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudBirimFiyat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStokAdeti).BeginInit();
            SuspendLayout();
            // 
            // cbxKategori
            // 
            cbxKategori.FormattingEnabled = true;
            cbxKategori.Location = new Point(149, 56);
            cbxKategori.Name = "cbxKategori";
            cbxKategori.Size = new Size(208, 28);
            cbxKategori.TabIndex = 0;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(149, 122);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(207, 27);
            txtUrunAdi.TabIndex = 1;
            // 
            // nudBirimFiyat
            // 
            nudBirimFiyat.DecimalPlaces = 2;
            nudBirimFiyat.Location = new Point(152, 206);
            nudBirimFiyat.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudBirimFiyat.Name = "nudBirimFiyat";
            nudBirimFiyat.Size = new Size(205, 27);
            nudBirimFiyat.TabIndex = 2;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(525, 37);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(211, 80);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(525, 132);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(211, 78);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGüncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(525, 233);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(211, 71);
            btnSil.TabIndex = 5;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // listViewProduct
            // 
            listViewProduct.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listViewProduct.GridLines = true;
            listViewProduct.Location = new Point(33, 414);
            listViewProduct.Name = "listViewProduct";
            listViewProduct.Size = new Size(743, 402);
            listViewProduct.TabIndex = 6;
            listViewProduct.UseCompatibleStateImageBehavior = false;
            listViewProduct.View = View.Details;
            listViewProduct.SelectedIndexChanged += listViewProduct_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ürün Adi";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Stok ";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Birim Fiyati";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Categori ID";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Durumu";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Eklenme Tarihi";
            columnHeader7.Width = 160;
            // 
            // btnGeriDon
            // 
            btnGeriDon.Location = new Point(33, 843);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new Size(743, 73);
            btnGeriDon.TabIndex = 7;
            btnGeriDon.Text = "KATEGORİ EKLEME EKRANINA DÖN";
            btnGeriDon.UseVisualStyleBackColor = true;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 64);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 8;
            label1.Text = "Kategori : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 132);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 8;
            label2.Text = "Ürün Adı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 213);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 8;
            label3.Text = "Birim Fiyatı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 284);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 8;
            label4.Text = "Stok Miktari :";
            // 
            // nudStokAdeti
            // 
            nudStokAdeti.Location = new Point(149, 277);
            nudStokAdeti.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
            nudStokAdeti.Name = "nudStokAdeti";
            nudStokAdeti.Size = new Size(205, 27);
            nudStokAdeti.TabIndex = 2;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 943);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGeriDon);
            Controls.Add(listViewProduct);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnKaydet);
            Controls.Add(nudStokAdeti);
            Controls.Add(nudBirimFiyat);
            Controls.Add(txtUrunAdi);
            Controls.Add(cbxKategori);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)nudBirimFiyat).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStokAdeti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Button btnKaydet;
        private Button btnGuncelle;
        private Button btnSil;
        private ListView listViewProduct;
        private Button btnGeriDon;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbxKategori;
        private TextBox txtUrunAdi;
        private NumericUpDown nudBirimFiyat;
        private NumericUpDown nudStokAdeti;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}