namespace BasicInvoiceApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required decimal Price { get; set; }
        public required string Description { get; set; }
        public List<InvoiceProduct> InvoiceProducts { get; set; } = new List<InvoiceProduct>();
    }
}
