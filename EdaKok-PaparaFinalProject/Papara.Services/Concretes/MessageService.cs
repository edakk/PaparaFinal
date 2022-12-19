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
  public  class MessageService : IMessageService
    {
        private readonly IMessageRepository<Message> _MessageRepository;
        public MessageService(IMessageRepository<Message> MessageRepository)
        {
            _MessageRepository = MessageRepository;

        }
        public void Add(Message Message)
        {
            _MessageRepository.Add(Message);
        }

        public void DeleteMessage(Message Message)
        {
            _MessageRepository.Remove(Message);
        }

        public IEnumerable<Message> Get(Message Message)
        {
            return _MessageRepository.Get(Message.MessageId).ToList();
        }

        public IEnumerable<Message> GetAll()
        {
            return _MessageRepository.GetAll().ToList();
        }

       

        public void UpdateMessage(Message Message)
        {
            _MessageRepository.Update(Message);
        }
    }
}
