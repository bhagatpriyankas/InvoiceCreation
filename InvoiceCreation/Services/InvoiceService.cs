using InvoiceCreation.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace InvoiceCreation.Services
{
    public class InvoiceService : IInvoice
    {
        private InvoiceDBContext _dbContext;
        public InvoiceService(InvoiceDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public void AddInvoiceAsync(InvoiceInfo invoiceInfo, List<InvoiceDetails> invoiceDetails)
        {
            _dbContext.AddAsync(invoiceInfo);
            _dbContext.AddAsync(invoiceDetails);
        }

        public IList<InvoiceInfo> GetAllInvoiceInfos() => (IList<InvoiceInfo>)_dbContext.InvoiceInfos.Include(o => o.Detail).ToListAsync();//throw new System.NotImplementedException();
        public InvoiceInfo GetInvoiceInfos(string id)
        {
            return _dbContext.InvoiceInfos.Include(o => o.Detail).Where(o => o.InvoiceID == id).SingleOrDefault();//throw new System.NotImplementedException();
        }

        public void UpdateInvoiceAsync(InvoiceInfo invoiceInfo, List<InvoiceDetails> invoiceDetails)
        {
            _dbContext.Update(invoiceInfo);
            _dbContext.Update(invoiceDetails);
        }
    }
}
