using InvoiceCreation.Entities;
using InvoiceCreation.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InvoiceCreation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;

        public InvoiceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        // GET: api/<InvoiceController>
        [HttpGet]
        public IList<InvoiceInfo> Get()
        {
            return _unitOfWork.Invoice.GetAllInvoiceInfos();
        }

        // GET api/<InvoiceController>/5
        [HttpGet("{id}")]
        public InvoiceInfo GetInvoice(string id)
        {
            return _unitOfWork.Invoice.GetInvoiceInfos(id);
        }

        // POST api/<InvoiceController>
        [HttpPost]
        public void AddInvoice([FromBody] InvoiceInfo invoiceInfo,List<InvoiceDetails> invoiceDetails)
        {
            _unitOfWork.Invoice.AddInvoiceAsync(invoiceInfo, invoiceDetails);
        }

        // PUT api/<InvoiceController>/5
        [HttpPut("{id}")]
        public void UpdateInvoice(int id, [FromBody] InvoiceInfo invoiceInfo, List<InvoiceDetails> invoiceDetails)
        {
            _unitOfWork.Invoice.UpdateInvoiceAsync(invoiceInfo, invoiceDetails);
        }

        //// DELETE api/<InvoiceController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
