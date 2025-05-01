using Microsoft.EntityFrameworkCore;

namespace BasicInvoiceApp.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Models.Customer> Customers { get; set; }
        public DbSet<Models.Invoice> Invoices { get; set; }
        public DbSet<Models.InvoiceProduct> InvoiceProducts { get; set; }
        public DbSet<Models.Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Add any additional configuration here
        }
    }
}
