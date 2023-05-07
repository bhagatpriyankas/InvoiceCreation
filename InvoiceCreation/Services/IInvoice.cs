using InvoiceCreation.Entities;
using System.Collections.Generic;

namespace InvoiceCreation.Services
{
    public interface IInvoice
    {
        IList<InvoiceInfo> GetAllInvoiceInfos();
        InvoiceInfo GetInvoiceInfos(string id);
        void AddInvoiceAsync(InvoiceInfo invoiceInfo, List<InvoiceDetails> invoiceDetails);
        void UpdateInvoiceAsync(InvoiceInfo invoiceInfo, List<InvoiceDetails> invoiceDetails);

    }
}
