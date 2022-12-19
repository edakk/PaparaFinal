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
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService InvoiceService;

        public InvoiceController(IInvoiceService InvoiceService)
        {
            this.InvoiceService = InvoiceService;
        }

        [Route("Invoices")]
        [HttpPost]

        public IActionResult AddInvoice(Invoice Invoice)
        {

          
            InvoiceService.Add(Invoice);
            return Ok("Success");
        }

        [Route("GetInvoice")]
        [HttpGet]

        public IActionResult GetById(int id)
        {
            var List = InvoiceService.GetAll();
            var Invoice = List.FirstOrDefault(x => x.InvoiceId == id);
            {
                if (Invoice.InvoiceId == id)
                {
                    InvoiceService.Get(Invoice);
                    return Ok(Invoice);
                }
                else
                    return BadRequest();
            }

        }
        [Route("UpdateInvoice")]
        [HttpPut]
        public IActionResult UpdateInvoice(Invoice Invoice)
        {
            InvoiceService.UpdateInvoice(Invoice);
            return Ok("Success");

        }

        [Route("DeleteInvoice")]
        [HttpDelete]
        public IActionResult DeleteInvoice(Invoice Invoice)
        {
           InvoiceService.DeleteInvoice(Invoice);
            return Ok("Succes");
        }


        [Route("GetAllInvoices")]
        [HttpGet]

        public ActionResult GetAllInvoice()
        {
            var result = InvoiceService.GetAll();
            return Ok(result);
        }


    }
}
