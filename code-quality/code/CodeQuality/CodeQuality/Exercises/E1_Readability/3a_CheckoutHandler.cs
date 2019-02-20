using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuality.E1_Readability
{
    public class CheckoutHandler_2
    {

        private Store Store { get; set; }

        public CheckoutState Checkout(List<Product> products, Customer customer)
        {
            foreach (var product in products)
            {
                if (Store.Stock.GetProducts(product.Code).Count() > 0)
                {
                    if (product.Code == "A")
                    {
                        return CheckoutState.MustShowId;
                    }
                    if (product.Code == "EX" || product.Code == "HAZ")
                    {
                        if(customer.WhiteListStatus != "Ok")
                            NotifyGovernmentOfPurchase();
                    }
                }
                else
                {
                    return CheckoutState.Failed;
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
