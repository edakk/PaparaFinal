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
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [Route("Users")]
        [HttpPost]

        public IActionResult AddUser(User user)
        {

          
            userService.Add(user);
            return Ok("Success");
        }

        [Route("GetUser")]
        [HttpGet]

        public IActionResult GetById(int id)
        {
            var List = userService.GetAll();
            var user = List.FirstOrDefault(x => x.UserId == id);
            {
                if (user.UserId == id)
                {
                    userService.Get(user);
                    return Ok(user);
                }
                else
                    return BadRequest();
            }

        }
        [Route("UpdateUser")]
        [HttpPut]
        public IActionResult UpdateUser(User user)
        {
            userService.UpdateUser(user);
            return Ok("Success");

        }

        [Route("DeleteUser")]
        [HttpDelete]
        public IActionResult DeleteUser(User user)
        {
           userService.DeleteUser(user);
            return Ok("Succes");
        }


        [Route("GetAllUsers")]
        [HttpGet]

        public ActionResult GetAllUser()
        {
            var result = userService.GetAll();
            return Ok(result);
        }


    }
}
