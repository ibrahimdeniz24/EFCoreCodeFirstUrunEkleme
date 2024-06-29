using _13_UrunEklemeOtomasyonu.Context;
using _13_UrunEklemeOtomasyonu.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListView = System.Windows.Forms.ListView;

namespace _13_UrunEklemeOtomasyonu
{
    public partial class Form3 : Form
    {
        private Form2 form2;
        public Form3(Form2 frm2) //form3'te form2 ye ulaşmamızı sağlıypor. form'nin kendisini göneriyoruz.
        {
            InitializeComponent();
            form2 = frm2;
        }

        ProjectDBContext context;
        Category category;
        Product product;


        private void Form3_Load(object sender, EventArgs e)
        {

            context = new ProjectDBContext();
            

             
            
                List<Category> categories = context.Categories.ToList(); //Where(kat=> kat.IsActive); aktif olanları getirme.

                //foreach (var item in categories)
                //{
                //    cbxKategori.Items.Add(item.Name.ToString());
                //}

                cbxKategori.DataSource = categories;
                cbxKategori.DisplayMember = "Name";
                cbxKategori.ValueMember = "ID";



                UrunleriListele(listViewProduct);
            

        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
           
            try
            {
                context = new ProjectDBContext();
                
                    Product product = new Product();
                    product.Name = txtUrunAdi.Text;
                    product.UnitPrice = nudBirimFiyat.Value;
                    product.Stock = Convert.ToInt16(nudStokAdeti.Value);
                    product.AddedDate = DateTime.Now;
                    product.IsActive = true;
                    product.CategoryID = Convert.ToInt32(cbxKategori.SelectedValue);

                    context.Products.Add(product);
                    context.SaveChanges();

                
            }
            catch (DbUpdateException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { UrunleriListele(listViewProduct); }

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            listViewProduct.Items.Clear();
            using (context = new ProjectDBContext())
            {

                try
                {
                    if (string.IsNullOrWhiteSpace(txtUrunAdi.Text))

                    {
                        MessageBox.Show("Lütfen Ürün adını boş bırakmayın. ");


                    }
                    else
                    {
                        product = context.Products.FirstOrDefault(c => c.Name == txtUrunAdi.Text);

                        context.Products.Remove(product);
                        context.SaveChanges();

                        MessageBox.Show("Ürün Başarı ile Silinmiştir.");


                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ürün Silinemedi Tekrar Deneyiniz.");
                }
                finally { UrunleriListele(listViewProduct); }


            }
        }


        public void UrunleriListele(ListView listview1)
        {
            listview1.Items.Clear();

            List<Product> products = context.Products.ToList();
            #region Inner Join

            //List<Category> categories = context.Categories.ToList();

            //var innerjoin1 = products.Join(
            //                        categories,
            //                        p => p.CategoryID,
            //                        c => c.ID,
            //                        (p, c) => new
            //                        {
            //                            ProductName = p.Name,
            //                            CategoryName = c.Name,
            //                            CategoryID = c.ID,
            //                            ProductID = p.ID,
            //                            Stock = p.Stock,
            //                            UnitPrice = p.UnitPrice
            //                        }
            //                        ); 
            #endregion


            foreach (Product item in products)
            {
                ListViewItem list = new ListViewItem(item.ID.ToString());
                list.SubItems.Add(item.Name.ToString());
                list.SubItems.Add(item.Stock.ToString());
                list.SubItems.Add(item.UnitPrice.ToString());
                list.SubItems.Add(item.CategoryID.ToString());
                list.SubItems.Add(item.IsActive.ToString());
                list.SubItems.Add(item.AddedDate.ToString());


                listview1.Items.Add(list);

            }
        }

        private void listViewProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            //seçilen satırı yakala ve içindeki değerleri form üstündeki kontrollere ata


            int productID=Convert.ToInt32(listViewProduct.SelectedItems[0].Text);

            Product product = context.Products.Find(productID);

            cbxKategori.SelectedValue = product.CategoryID;
            txtUrunAdi.Text = product.Name;
            nudBirimFiyat.Value = product.UnitPrice ?? 0;
            nudStokAdeti.Value = product.Stock ?? 0;

            
        }
    }
}

