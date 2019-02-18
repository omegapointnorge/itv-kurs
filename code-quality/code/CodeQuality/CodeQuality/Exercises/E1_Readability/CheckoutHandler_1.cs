using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuality.E1_Readability
{
    public class CheckoutHandler_1
    {
        private ClientRegistry Store { get; set; }

        public CheckoutState Checkout(List<Product> products)
        {

            foreach (var product in products)
            {

                if (product.Code == "EX" || product.Code == "HAZ")
                {
                    NotifyGovernmentOfPurchase();
                }

            }

            return CheckoutState.Completed;

        }

        private void NotifyGovernmentOfPurchase()
        {
            throw new NotImplementedException();
        }
    }
}
