using Papara.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papara.Services.Abstracts
{
   public interface IUserService
    {

        public IEnumerable<User> Get(User User);
        public IEnumerable<User> GetAll();
       
        void Add(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
    }
}
