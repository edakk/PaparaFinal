using Microsoft.EntityFrameworkCore;
using Papara.Data.Abstracts;
using Papara.Data.Context;
using Papara.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papara.Data.Concretes
{
    public class ApartmentRepository<T> : IApartmentRepository<T> where T : Apartment
    {
        private readonly FDbContext _context;
        public ApartmentRepository(FDbContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _context.Set<T>().Add(entity);
            _context.SaveChanges();

        }

        public IQueryable<T> Get(int id)
        {
            return _context.Set<T>()
               .Where(u => u.ApartmentId == id)
               .AsQueryable();
        }

       
        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsQueryable();
        }

       

        public void Remove(T entity)
        {
            var modal = _context.Set<T>().Find(entity.ApartmentId);
            if (modal != null)
            {
                _context.Entry(modal).State = EntityState.Detached;
                _context.Set<T>().Remove(entity);
                _context.SaveChanges();
            }
        }
        public void Update(T entity)
        {

            var modal = _context.Set<T>().Find(entity.ApartmentId);
            if (modal != null)
            {
                _context.Entry(modal).State = EntityState.Detached;
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
    }

}
