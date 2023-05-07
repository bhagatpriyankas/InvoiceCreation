namespace InvoiceCreation.Services
{
    public interface IUnitOfWork
    {
        IInvoice Invoice { get; }
        void Save();
    }
}
