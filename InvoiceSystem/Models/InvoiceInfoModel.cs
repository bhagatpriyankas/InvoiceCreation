using System;
using System.ComponentModel;

namespace InvoiceSystem.Models
{
    public class InvoiceInfoModel
    {
        [DisplayName("Incoice No")]
        public string InvoiceID { get; set; }
        [DisplayName("Bill To")]
        public string BillTo { get; set; }
        public string Invoice { get; set; }
        [DisplayName("Date")]
        public DateTime InvoiceDate { get; set; }

        [DisplayName("Due Date")]
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
        public InvoiceDetailsModel Detail { get; set; }
        public CustomerModel Customer { get; set; }
    }
}
