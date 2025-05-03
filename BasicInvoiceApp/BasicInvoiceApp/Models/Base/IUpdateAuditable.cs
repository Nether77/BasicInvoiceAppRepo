namespace BasicInvoiceApp.Models.Base
{
    public interface IUpdateAuditable
    {
        string UpdatedBy { get; set; }
        DateTime UpdatedDate { get; set; }
    }
}
