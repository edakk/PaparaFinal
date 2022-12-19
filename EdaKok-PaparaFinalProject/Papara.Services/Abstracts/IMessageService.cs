using Papara.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papara.Services.Abstracts
{
   public interface IMessageService
    {

        public IEnumerable<Message> Get(Message Message);
        public IEnumerable<Message> GetAll();
      
        void Add(Message Message);
        void UpdateMessage(Message Message);
        void DeleteMessage(Message Message);
    }
}
