using CodeQuality.E3_Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuality.S3_Functions
{
    public class InvoiceHandler : IInvoiceHandler
    {
        public Invoice CreateInvoice(int productId, int negativeOrPositiveAmount)
        {
            var priceCalcualtor = new PriceCalculator();
            var invoicePrice = priceCalcualtor.GetPriceByProductIdAndAmount(productId, negativeOrPositiveAmount);
            return new Invoice(invoicePrice, productId, negativeOrPositiveAmount);
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
        public double GetPriceByProductIdAndAmount(int productId, int negativeOrPositiveAmount)
        {
            if (negativeOrPositiveAmount == 0)
            {
                throw new ArgumentException("Amount can not be 0");
            }

            var product = GetProductById(productId);
            var price = product.Price * negativeOrPositiveAmount;
            return price;
        }

        private Product GetProductById(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
