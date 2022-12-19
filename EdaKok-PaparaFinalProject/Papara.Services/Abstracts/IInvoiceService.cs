using Papara.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papara.Services.Abstracts
{
   public interface IInvoiceService
    {

        public IEnumerable<Invoice> Get(Invoice Invoice);
        public IEnumerable<Invoice> GetAll();
     
        void Add(Invoice Invoice);
        void UpdateInvoice(Invoice Invoice);
        void DeleteInvoice(Invoice Invoice);
    }
}
