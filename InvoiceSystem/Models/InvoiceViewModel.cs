using System.Collections.Generic;

namespace InvoiceSystem.Models
{
    public class InvoiceViewModel
    {
        public InvoiceInfoModel Info { get; set; }
        public List<InvoiceDetailsModel> Details { get; set; }

    }
}
