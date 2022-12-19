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
   public class ApartmentService : IApartmentService
    {
        private readonly IApartmentRepository<Apartment> _ApartmentRepository;
        public ApartmentService(IApartmentRepository<Apartment> ApartmentRepository)
        {
            _ApartmentRepository = ApartmentRepository;

        }
        public void Add(Apartment Apartment)
        {
            _ApartmentRepository.Add(Apartment);
        }

        public void DeleteApartment(Apartment Apartment)
        {
            _ApartmentRepository.Remove(Apartment);
        }

        public IEnumerable<Apartment> Get(Apartment Apartment)
        {
            return _ApartmentRepository.Get(Apartment.ApartmentId).ToList();
        }

        public IEnumerable<Apartment> GetAll()
        {
            return _ApartmentRepository.GetAll().ToList();
        }

        

        public void UpdateApartment(Apartment Apartment)
        {
            _ApartmentRepository.Update(Apartment);
        }
    }
}

