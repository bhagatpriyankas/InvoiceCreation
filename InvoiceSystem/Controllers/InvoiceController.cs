using InvoiceSystem.Models;
using InvoiceSystem.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net.Http;

namespace InvoiceSystem.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly IInvoiceService _invoiceService;

        public InvoiceController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }


        // GET: InvoiceController
        public ActionResult Index()
        {
            return View();
        }

        // GET: InvoiceController/Details/5
        public ActionResult Details()
        {
            var invoiceData = _invoiceService.GetAllInvoiceInfos();
            return View(invoiceData);
        }

        // GET: InvoiceController/Details/5
        public ActionResult Details(string id)
        {
            var invoiceData = _invoiceService.GetInvoiceInfos(id);
            return View(invoiceData);
        }

        // GET: InvoiceController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: InvoiceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(InvoiceViewModel collection)
        {
            try
            {
                var invoiceData = _invoiceService.AddInvoiceAsync(collection.Info,collection.Details);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InvoiceController/Edit/5
        public ActionResult Edit(string id, InvoiceInfoModel invoiceInfo, List<InvoiceDetailsModel> invoiceDetails)
        {
            var invoiceData = _invoiceService.UpdateInvoiceAsync(invoiceInfo, invoiceDetails);
            return View(invoiceData);
        }

        // POST: InvoiceController/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, InvoiceViewModel collection)
        {
            try
            {
                Edit(id, collection.Info, collection.Details);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        //// GET: InvoiceController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: InvoiceController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
