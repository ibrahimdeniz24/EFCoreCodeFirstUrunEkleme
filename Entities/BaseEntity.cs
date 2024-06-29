using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_UrunEklemeOtomasyonu.Entities
{
    internal class BaseEntity
    {
        [Key] // Kolonu PK olarak ayarla. Identity kolon ve 1'den başlayıp 1'er 1'er artsın.
        [Column(Order =1)] //Bütün tablolarda 1. kolonda olsun.
        public int ID { get; set; }

        [Required] // bu alan zorunlu olsun.
        [Column(Order = 2)] //Bütün tablolarda 2. kolonda olsun.
        public string Name { get; set; }


        public bool IsActive { get; set; }

        //Datetime sonuna soru işareti nullable bir kolon olabilir diyoruz.
        [Column(TypeName ="datetime2")] //Kolon tipini datetime2 olarak ayarlansın. Eğer bu ayarlanmazsa DB'de datetime türünde olur.
        public DateTime? AddedDate { get; set; }
    }
}
