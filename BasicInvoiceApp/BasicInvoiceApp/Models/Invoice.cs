namespace BasicInvoiceApp.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public required DateTime Date { get; set; }
        public required decimal TotalAmount { get; set; }
        public required string Status { get; set; } // e.g., "Paid", "Unpaid"
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null;
        public List<InvoiceProduct> InvoiceProducts { get; set; } = new List<InvoiceProduct>();
    }
}
