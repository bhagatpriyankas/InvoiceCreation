using InvoiceSystem.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InvoiceSystem.Service
{
    public interface IInvoiceService
    {
        Task<IList<InvoiceInfoModel>> GetAllInvoiceInfos();
        Task<InvoiceInfoModel> GetInvoiceInfos(string id);
        Task AddInvoiceAsync(InvoiceInfoModel invoiceInfo, List<InvoiceDetailsModel> invoiceDetails);
        Task UpdateInvoiceAsync(InvoiceInfoModel invoiceInfo, List<InvoiceDetailsModel> invoiceDetails);
    }
}
