using BasicInvoiceApp.Models.Base;

namespace BasicInvoiceApp.Models
{
    public class InvoiceProduct : IAddAuditable, IUpdateAuditable
    {
        public InvoiceProduct() { }

        public InvoiceProduct(int invoiceId, int productId, int quantity)
        {
            InvoiceId = invoiceId;
            ProductId = productId;
            Quantity = quantity;
        }

        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; } = null!;
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal TotalPrice => Product.Price * Quantity;

        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
