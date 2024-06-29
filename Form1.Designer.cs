namespace _13_UrunEklemeOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtKullanıcıAdi = new TextBox();
            txtSifre = new TextBox();
            lblAd = new Label();
            label2 = new Label();
            btnGiris = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtKullanıcıAdi
            // 
            txtKullanıcıAdi.BorderStyle = BorderStyle.FixedSingle;
            txtKullanıcıAdi.Location = new Point(314, 71);
            txtKullanıcıAdi.Margin = new Padding(4);
            txtKullanıcıAdi.Multiline = true;
            txtKullanıcıAdi.Name = "txtKullanıcıAdi";
            txtKullanıcıAdi.Size = new Size(350, 28);
            txtKullanıcıAdi.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.BorderStyle = BorderStyle.FixedSingle;
            txtSifre.Location = new Point(314, 162);
            txtSifre.Margin = new Padding(4);
            txtSifre.Multiline = true;
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(350, 35);
            txtSifre.TabIndex = 1;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(61, 71);
            lblAd.Margin = new Padding(4, 0, 4, 0);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(143, 28);
            lblAd.TabIndex = 1;
            lblAd.Text = "Kullanıcı Adi :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 169);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 28);
            label2.TabIndex = 1;
            label2.Text = "Şifre :";
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(314, 232);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(350, 102);
            btnGiris.TabIndex = 2;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGiris);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblAd);
            groupBox1.Controls.Add(txtSifre);
            groupBox1.Controls.Add(txtKullanıcıAdi);
            groupBox1.Location = new Point(25, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(726, 369);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giriş Ekranı";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 394);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtKullanıcıAdi;
        private TextBox txtSifre;
        private Label lblAd;
        private Label label2;
        private Button btnGiris;
        private ContextMenuStrip contextMenuStrip1;
        private GroupBox groupBox1;
    }
}
