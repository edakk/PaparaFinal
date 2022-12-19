using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Papara.Data.Abstracts
{
   public interface IInvoiceRepository<T> where T : class
    {
        IQueryable<T> Get(int id);
        // T GetById(int id);
        IQueryable<T> GetAll();
        //  IQueryable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);

    }
}
