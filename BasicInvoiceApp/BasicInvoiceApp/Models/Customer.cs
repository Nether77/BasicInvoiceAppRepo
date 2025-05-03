using BasicInvoiceApp.Models.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasicInvoiceApp.Models
{
    public class Customer : IAddAuditable, IUpdateAuditable
    {
        public int Id {  get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public required string Address { get; set; }
        public List<Invoice> Invoices { get; set; } = new List<Invoice>();
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }

    public class CustomerEfConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Email).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Phone).IsRequired().HasMaxLength(15);
            builder.Property(c => c.Address).IsRequired().HasMaxLength(200);
        }
    }
}
