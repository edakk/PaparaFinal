using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papara.Domain.Entities
{
   public class Apartment
    {
        [Key]
        public int ApartmentId { get; set; }

        [Required]
        [ForeignKey("Users")]
        public int UserId { get; set; }
        public  User User { get; set; }
        public string Block { get; set; }
        public bool IsEmpty  { get; set; }
        public string Type { get; set; }

        public int FloorNum { get; set; }
        public int ApartmentNum { get; set; }
        public bool IsOwner { get; set;
        }

    }
}
