using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuality.E2_Readability
{
    public class CheckoutHandler_2
    {
        private Store Store { get; set; }

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
