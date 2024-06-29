namespace _13_UrunEklemeOtomasyonu
{
    partial class Form2
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
            txtKaterogiAcik = new TextBox();
            lblKategoriAdi = new Label();
            txtKategoriAdi = new TextBox();
            label2 = new Label();
            btnKategoriEkle = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            btnUrunEkle = new Button();
            grpKategoriEkleme = new GroupBox();
            grpKategoriler = new GroupBox();
            btnSil = new Button();
            grpKategoriEkleme.SuspendLayout();
            grpKategoriler.SuspendLayout();
            SuspendLayout();
            // 
            // txtKaterogiAcik
            // 
            txtKaterogiAcik.Location = new Point(186, 125);
            txtKaterogiAcik.Name = "txtKaterogiAcik";
            txtKaterogiAcik.Size = new Size(326, 31);
            txtKaterogiAcik.TabIndex = 0;
            // 
            // lblKategoriAdi
            // 
            lblKategoriAdi.AutoSize = true;
            lblKategoriAdi.Location = new Point(23, 51);
            lblKategoriAdi.Name = "lblKategoriAdi";
            lblKategoriAdi.Size = new Size(119, 25);
            lblKategoriAdi.TabIndex = 1;
            lblKategoriAdi.Text = "Kategori Adi :";
            // 
            // txtKategoriAdi
            // 
            txtKategoriAdi.Location = new Point(186, 48);
            txtKategoriAdi.Name = "txtKategoriAdi";
            txtKategoriAdi.Size = new Size(326, 31);
            txtKategoriAdi.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 131);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 1;
            label2.Text = "Açıklaması :";
            // 
            // btnKategoriEkle
            // 
            btnKategoriEkle.Location = new Point(12, 204);
            btnKategoriEkle.Name = "btnKategoriEkle";
            btnKategoriEkle.Size = new Size(578, 138);
            btnKategoriEkle.TabIndex = 2;
            btnKategoriEkle.Text = "KategoriEkle";
            btnKategoriEkle.UseVisualStyleBackColor = true;
            btnKategoriEkle.Click += btnKategoriEkle_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.GridLines = true;
            listView1.Location = new Point(6, 33);
            listView1.Name = "listView1";
            listView1.Size = new Size(748, 474);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;

            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Kategori Adi";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Açıklama";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Eklenme Tarihi";
            columnHeader4.Width = 160;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Aktif Durumu";
            columnHeader5.Width = 140;
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.Location = new Point(12, 904);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(760, 55);
            btnUrunEkle.TabIndex = 4;
            btnUrunEkle.Text = "Ürün Ekle";
            btnUrunEkle.UseVisualStyleBackColor = true;
            btnUrunEkle.Click += btnUrunEkle_Click;
            // 
            // grpKategoriEkleme
            // 
            grpKategoriEkleme.Controls.Add(label2);
            grpKategoriEkleme.Controls.Add(lblKategoriAdi);
            grpKategoriEkleme.Controls.Add(txtKategoriAdi);
            grpKategoriEkleme.Controls.Add(txtKaterogiAcik);
            grpKategoriEkleme.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            grpKategoriEkleme.Location = new Point(5, 4);
            grpKategoriEkleme.Name = "grpKategoriEkleme";
            grpKategoriEkleme.Size = new Size(578, 194);
            grpKategoriEkleme.TabIndex = 5;
            grpKategoriEkleme.TabStop = false;
            grpKategoriEkleme.Text = "Kategori Ekleme Paneli";
            // 
            // grpKategoriler
            // 
            grpKategoriler.Controls.Add(listView1);
            grpKategoriler.Location = new Point(12, 352);
            grpKategoriler.Name = "grpKategoriler";
            grpKategoriler.Size = new Size(760, 513);
            grpKategoriler.TabIndex = 6;
            grpKategoriler.TabStop = false;
            grpKategoriler.Text = "Kategoriler";
            // 
            // btnSil
            // 
            btnSil.Location = new Point(621, 12);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(145, 330);
            btnSil.TabIndex = 7;
            btnSil.Text = "Kategori Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 982);
            Controls.Add(btnSil);
            Controls.Add(grpKategoriler);
            Controls.Add(grpKategoriEkleme);
            Controls.Add(btnUrunEkle);
            Controls.Add(btnKategoriEkle);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            grpKategoriEkleme.ResumeLayout(false);
            grpKategoriEkleme.PerformLayout();
            grpKategoriler.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtKaterogiAcik;
        private Label lblKategoriAdi;
        private TextBox txtKategoriAdi;
        private Label label2;
        private Button btnKategoriEkle;
        private ListView listView1;
        private Button btnUrunEkle;
        private GroupBox grpKategoriEkleme;
        private GroupBox grpKategoriler;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button btnSil;
    }
}