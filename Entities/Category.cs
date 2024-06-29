using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_UrunEklemeOtomasyonu.Entities
{
    internal class Category : BaseEntity
    {
        [MaxLength(255)] // eğer maximum uzunluk verilmezise nvarchar(max ) olarak ayarlanır.
        public string Description { get; set; }


        //Bir categorinin birden fazla ürünü olabilir.
        public ICollection<Product> Products { get; set; }


    }
}
