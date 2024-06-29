using _13_UrunEklemeOtomasyonu.Context;
using _13_UrunEklemeOtomasyonu.Entities;
using Microsoft.VisualBasic.ApplicationServices;

namespace _13_UrunEklemeOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        ProjectDBContext context;


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

            try
            {
                using (context = new ProjectDBContext())
                {

                    //Ayný kullanýcý ayný þifre uinq deðil username kolonu sistemde birden fazla geliyorsa 2 tane varsa hata verecek.
                    var user = context.Users.SingleOrDefault(x => x.UserName == txtKullanýcýAdi.Text || x.Password == txtSifre.Text);


                    if (user != null)
                    {

                        Form2 form2 = new Form2();
                        form2.ShowDialog();

                        this.Hide();

                    }
                    else
                    { MessageBox.Show("Hatalý Giriþ Tekrar Deneyiniz"); }


                }

            }
            catch (Exception)
            {

                throw;
            }
            



        }

    }


}
