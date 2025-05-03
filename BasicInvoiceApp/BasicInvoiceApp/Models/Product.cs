using BasicInvoiceApp.Models.Base;

namespace BasicInvoiceApp.Models
{
    public class Product : IAddAuditable, IUpdateAuditable
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required decimal Price { get; set; }
        public required string Description { get; set; }
        public List<InvoiceProduct> InvoiceProducts { get; set; } = new List<InvoiceProduct>();
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
