namespace CodeQuality.E3_Functions
{
    public interface IInvoiceHandler
    {
        Invoice CreateInvoice(int productId, int amount);
        Invoice CreditInvoice(Invoice invoice);
    }
}