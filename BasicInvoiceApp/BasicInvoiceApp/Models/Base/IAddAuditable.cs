namespace BasicInvoiceApp.Models.Base
{
    public interface IAddAuditable
    {
        string CreatedBy { get; set; }
        DateTime CreatedDate { get; set; }
    }
}
