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
    public class ApartmentController : ControllerBase
    {
        private readonly IApartmentService ApartmentService;

        public ApartmentController(IApartmentService ApartmentService)
        {
            this.ApartmentService = ApartmentService;
        }

        [Route("Apartments")]
        [HttpPost]

        public IActionResult AddApartment(Apartment Apartment)
        {


            ApartmentService.Add(Apartment);
            return Ok("Success");
        }

        [Route("GetApartment")]
        [HttpGet]

        public IActionResult GetById(int id)
        {
            var List = ApartmentService.GetAll();
            var Apartment = List.FirstOrDefault(x => x.ApartmentId == id);
            {
                if (Apartment.ApartmentId == id)
                {
                    ApartmentService.Get(Apartment);
                    return Ok(Apartment);
                }
                else
                    return BadRequest();
            }

        }
        [Route("UpdateApartment")]
        [HttpPut]
        public IActionResult UpdateApartment(Apartment Apartment)
        {
            ApartmentService.UpdateApartment(Apartment);
            return Ok("Success");

        }

        [Route("DeleteApartment")]
        [HttpDelete]
        public IActionResult DeleteApartment(Apartment Apartment)
        {
            ApartmentService.DeleteApartment(Apartment);
            return Ok("Succes");
        }


        [Route("GetAllApartments")]
        [HttpGet]

        public ActionResult GetAllApartment()
        {
            var result = ApartmentService.GetAll();
            return Ok(result);
        }


    }
}

   