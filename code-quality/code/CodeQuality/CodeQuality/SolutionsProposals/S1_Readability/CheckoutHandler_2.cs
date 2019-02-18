using CodeQuality.E1_Readability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuality.S1_Readability
{
    public class CheckoutHandler_2
    {
        private Store Store { get; set; }

        public CheckoutState Checkout(List<Product> products)
        {

            foreach (var product in products)
            {

                bool productIsInStock = Store.Stock.GetProducts(product.Code).Count() > 0;
                if (!productIsInStock) { return CheckoutState.OutOfStock; }

                bool productIsAlcohol = product.Code == "A";
                if (productIsAlcohol)
                {
                    return CheckoutState.MustShowId;
                }
            }

            return CheckoutState.Completed;

        }
    }
}
