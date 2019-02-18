namespace CodeQuality.E3_Functions
{
    public class Invoice
    {
        public double InvoicePrice { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; internal set; }
        public object Status { get; internal set; }

        public Invoice(double invoicePrice, int productId, int amount)
        {
            InvoicePrice = invoicePrice;
            ProductId = ProductId;
            Amount = Amount;
        }

    }
}