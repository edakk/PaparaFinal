using Papara.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papara.Services.Abstracts
{
   public interface IApartmentService
    {
        public IEnumerable<Apartment> Get(Apartment Apartment);
        public IEnumerable<Apartment> GetAll();
        // Task<IReadOnlyList<Apartment>> GetAll();
        //  Task<Apartment> GetApartmentById(int id);
        void Add(Apartment Apartment);
        void UpdateApartment(Apartment Apartment);
        void DeleteApartment(Apartment Apartment);
    }
}
