using _13_UrunEklemeOtomasyonu.Context;
using _13_UrunEklemeOtomasyonu.Entities;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_UrunEklemeOtomasyonu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        ProjectDBContext context;
        Category category;
        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            using (context = new ProjectDBContext())
            {
                category = new Category();

                try
                {
                    if (string.IsNullOrWhiteSpace(txtKategoriAdi.Text))
                    {
                        MessageBox.Show("Lütfen Kategori adını boş bırakmayın. ");
                    }

                    else if (context.Categories.Any(c => c.Name == txtKategoriAdi.Text.Trim()))
                    {
                        MessageBox.Show("Aynı isimde Kategori  vardır. Lütfen Kontrol Ediniz ");
                    }
                    else
                    {
                        category.Name = txtKategoriAdi.Text.Trim();
                        category.Description = txtKaterogiAcik.Text.Trim();
                        category.AddedDate = DateTime.Now;
                        category.IsActive = true;

                        context.Categories.Add(category);
                        context.SaveChanges();
                        MessageBox.Show("Kategori  başarılı ile eklenmiştir.");


                        btnKategoriEkle.Enabled = true;

                        txtKategoriAdi.Text = "";
                        txtKaterogiAcik.Text = "";
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally { KategorileriListele(listView1); }

            }
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.ShowDialog();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            using (context = new ProjectDBContext())
            {
                btnKategoriEkle.Enabled = context.Categories.ToList().Count > 0 ? true : false;

                KategorileriListele(listView1);

            }


        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();

            using (context = new ProjectDBContext())
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(txtKategoriAdi.Text))

                    {
                        MessageBox.Show("Lütfen Kategori adını boş bırakmayın. ");

                    }
                    else
                    {
                        category = context.Categories.FirstOrDefault(c => c.Name == txtKategoriAdi.Text);

                        context.Categories.Remove(category);
                        context.SaveChanges();

                        MessageBox.Show("Categori Başarı ile Silinmiştir.");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Categori Silinemedi Tekrar Deneyiniz.");
                }
                finally { KategorileriListele(listView1); }
            }

        }

        public void KategorileriListele(ListView listview1)
        {
            listview1.Items.Clear();
            List<Category> categories = context.Categories.ToList(); //Where(x => x.IsActive) aktiv olanları göstermek için kullanarbiliriz.

            foreach (var item in categories)
            {
                ListViewItem list = new ListViewItem(item.ID.ToString()); //İlk kolona ekelem yaparken contrcuker kullandık.
                list.SubItems.Add(item.Name.ToString());
                list.SubItems.Add(item.Description.ToString());
                list.SubItems.Add(item.AddedDate.ToString());
                list.SubItems.Add(item.IsActive.ToString());


                listview1.Items.Add(list);

            }

        }

    }
}
