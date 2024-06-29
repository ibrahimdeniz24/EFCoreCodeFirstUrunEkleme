using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_UrunEklemeOtomasyonu.Entities
{
    internal class Product : BaseEntity
    {
        public decimal? UnitPrice { get; set; }
        public short? Stock { get; set; }

        [ForeignKey("Category")] // categoriden fk aldıgını soyluyoruz.
        public int CategoryID { get; set; }
        //Bir ürünün bir kategorisi vardır.
        
        public Category Category { get; set; }
    }
}
