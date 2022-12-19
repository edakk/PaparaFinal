using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papara.Domain.Entities
{
   public class Message
    {
        [Key]
        public int MessageId { get; set; }
        public int SenderId { get; set; }

        public int ReceiverId { get; set; }

        public string Body { get; set; }
        public bool IsRead{ get; set; }
        public DateTime SendDate { get; set; }

    }
}
