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
  public  class UserService : IUserService
    {
        private readonly IUserRepository<User> _userRepository;
        public UserService(IUserRepository<User> userRepository)
        {
            _userRepository = userRepository;

        }
        public void Add(User user)
        {
            _userRepository.Add(user);
        }

        public void DeleteUser(User user)
        {
            _userRepository.Remove(user);
        }

        public IEnumerable<User> Get(User User)
        {
            return _userRepository.Get(User.UserId).ToList();
        }

        public IEnumerable<User> GetAll()
        {
            return _userRepository.GetAll().ToList();
        }

        /*   public async Task<IReadOnlyList<User>> GetAll()
           {
               return await _userRepository.GetAll();
           }

           public async Task<User> GetUserById(int id)
           {
               return await _userRepository.GetById(id);
           }
        */

        public void UpdateUser(User user)
        {
            _userRepository.Update(user);
        }
    }
}
