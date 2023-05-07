

using Microsoft.EntityFrameworkCore;

namespace InvoiceCreation.Entities
{
    public class InvoiceDBContext : DbContext
    {
        public InvoiceDBContext(DbContextOptions<InvoiceDBContext> options):base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<InvoiceInfo> InvoiceInfos { get; set; }
        public DbSet<InvoiceDetails> InvoicesDetails { get; set; }  
    }
}
