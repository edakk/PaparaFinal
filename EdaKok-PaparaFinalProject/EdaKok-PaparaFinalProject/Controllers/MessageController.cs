using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Papara.Domain.Entities;
using Papara.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdaKok_PaparaFinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService MessageService;

        public MessageController(IMessageService MessageService)
        {
            this.MessageService = MessageService;
        }

        [Route("Messages")]
        [HttpPost]

        public IActionResult AddMessage(Message Message)
        {

          
            MessageService.Add(Message);
            return Ok("Success");
        }

        [Route("GetMessage")]
        [HttpGet]

        public IActionResult GetById(int id)
        {
            var List = MessageService.GetAll();
            var Message = List.FirstOrDefault(x => x.MessageId == id);
            {
                if (Message.MessageId == id)
                {
                    MessageService.Get(Message);
                    return Ok(Message);
                }
                else
                    return BadRequest();
            }

        }
       

        [Route("DeleteMessage")]
        [HttpDelete]
        public IActionResult DeleteMessage(Message Message)
        {
           MessageService.DeleteMessage(Message);
            return Ok("Succes");
        }


        [Route("GetAllMessages")]
        [HttpGet]

        public ActionResult GetAllMessage()
        {
            var result = MessageService.GetAll();
            return Ok(result);
        }


    }
}
