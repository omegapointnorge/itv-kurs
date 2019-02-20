using CodeQuality.E1_Readability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuality.S1_Readability
{
    public class CheckoutHandler_1
    {
        private ClientRegistry Store { get; set; }

        public CheckoutState Checkout(List<Product> products)
        {

            foreach (var product in products)
            {
                if (ProductIsMarkedAsPotentiallyDangerous(product))
                {
                    NotifyGovernmentOfPurchase(product);
                }
            }

            return CheckoutState.Completed;

        }

        private bool ProductIsMarkedAsPotentiallyDangerous(Product product)
        {
            return product.Code == "EX" || product.Code == "HAZ";
        }

        private void NotifyGovernmentOfPurchase(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
