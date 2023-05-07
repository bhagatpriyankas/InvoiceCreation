using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace InvoiceCreation.Entities
{
    public class InvoiceInfo
    {
        [Key]
        public string InvoiceID { get; set; }
        public string BillTo { get; set; }     
        public string Invoice { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; }        
        public InvoiceDetails Detail { get; set; }
        public Customer Customer { get; set; }
    }
}
