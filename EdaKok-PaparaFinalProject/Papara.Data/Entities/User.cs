using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papara.Domain.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public int IdentityNo { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int PhoneNum { get; set; }
        public string CarInfo { get; set; }

        [Required]
        [ForeignKey("Roles")]
        public int RoleId { get; set; }
        public  Role Role{ get; set; }


        public bool IsPaid { get; set; }
        public int Id { get; set; }
    }
}
