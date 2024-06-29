using _13_UrunEklemeOtomasyonu.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_UrunEklemeOtomasyonu.Context
{
    internal class ProjectDBContext :DbContext
    {

        //Aşağıdaki property'ler oluşacak DB'de yer almasının istediğimiz tabloları temsl eden Class'lardan oluşur. Buraya eklenmeyen Class, DB'ye de tablo olarak gitmez. Aynı zamanda, buradaki property isimleri KEsinlikle tablo isimleri değil, uygulamadaki DB'deki tablolara ulşaırken kullacak property isimleridir.

        // BaseEntity, bizim için ortak propetry'leri tuttugumuz bir class oldguundan burada tablo olutumaya eklemiyouz.

        public DbSet<AppUser> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data Source = DENIZ\SQL; Initial Catalog = HS15-ProductDB; Integrated Security = True; TrustServerCertificate = True");

            base.OnConfiguring(optionsBuilder);
        }

    }


}
