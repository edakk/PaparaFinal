using Papara.Data.Abstracts;
using Papara.Domain.Entities;
using Papara.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papara.Services.Concretes
{
  public  class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository<Invoice> _InvoiceRepository;
        public InvoiceService(IInvoiceRepository<Invoice> InvoiceRepository)
        {
            _InvoiceRepository = InvoiceRepository;

        }
        public void Add(Invoice Invoice)
        {
            _InvoiceRepository.Add(Invoice);
        }

        public void DeleteInvoice(Invoice Invoice)
        {
            _InvoiceRepository.Remove(Invoice);
        }

        public IEnumerable<Invoice> Get(Invoice Invoice)
        {
            return _InvoiceRepository.Get(Invoice.InvoiceId).ToList();
        }

        public IEnumerable<Invoice> GetAll()
        {
            return _InvoiceRepository.GetAll().ToList();
        }

        /*   public async Task<IReadOnlyList<Invoice>> GetAll()
           {
               return await _InvoiceRepository.GetAll();
           }

           public async Task<Invoice> GetInvoiceById(int id)
           {
               return await _InvoiceRepository.GetById(id);
           }
        */

        public void UpdateInvoice(Invoice Invoice)
        {
            _InvoiceRepository.Update(Invoice);
        }
    }
}
