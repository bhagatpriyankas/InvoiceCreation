using InvoiceCreation.Entities;

namespace InvoiceCreation.Services
{
    public class UnitOfWorkService : IUnitOfWork
    {
        private InvoiceDBContext _dBContext;
        private IInvoice _invoice;
        public UnitOfWorkService(InvoiceDBContext dBContext)
        {
            _dBContext = dBContext;
        }
    
        public IInvoice Invoice { get { return _invoice = _invoice ?? new InvoiceService(_dBContext); } }

        public void Save()
        {
            _dBContext.SaveChanges();
        }
    }
}
