using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papara.Domain.Entities
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }

        [Required]
        [ForeignKey("Apartments")]
        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public int Cost { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CreatedDate { get; set; }

        public bool  IsPaid { get; set; }


    }
}
