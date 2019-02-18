using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuality.E3_Functions
{
    public class InvoiceHandler : IInvoiceHandler
    {
        public Invoice CreateInvoice(int productId, int amount)
        {
            var priceCalcualtor = new PriceCalculator();
            var invoicePrice = priceCalcualtor.GetPriceByProductIdAndAmount(productId, amount);
            return new Invoice(invoicePrice, productId, amount);
        }

        public Invoice CreditInvoice(Invoice invoice)
        {
            var creditAmount = -invoice.Amount;
            var creditNote = CreateInvoice(invoice.ProductId, creditAmount);
            invoice.Status = InvoiceStatus.Credited;
            return creditNote;
        }
    }

    internal class PriceCalculator
    {
        public double GetPriceByProductIdAndAmount(int productId, int amount)
        {
            var product = GetProductById(productId);
            var price = product.Price * amount;
            return Math.Max(0, price);
        }

        private Product GetProductById(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
