using BasicInvoiceApp.Models.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasicInvoiceApp.Models
{
    public class Invoice : IAddAuditable, IUpdateAuditable
    {
        public int Id { get; set; }
        public required DateTime Date { get; set; }
        public required decimal TotalAmount { get; set; }
        public required string Status { get; set; } // e.g., "Paid", "Unpaid"
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null;
        public List<InvoiceProduct> InvoiceProducts { get; set; } = new List<InvoiceProduct>();
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }

    public class InvoiceEfConfig : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Date).IsRequired();
            builder.Property(i => i.TotalAmount).IsRequired();
            builder.Property(i => i.Status).IsRequired().HasMaxLength(50);
            builder.HasOne(i => i.Customer)
                .WithMany(c => c.Invoices)
                .HasForeignKey(i => i.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
