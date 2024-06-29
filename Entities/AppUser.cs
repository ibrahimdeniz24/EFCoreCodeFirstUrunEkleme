using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_UrunEklemeOtomasyonu.Entities
{
    internal class AppUser : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public string LastName { get; set; }

        [NotMapped]
        public string FullName => $" {Name} {LastName}";

        public bool Gender { get; set; }

        public DateTime? BirthDate { get; set; }



    }
}