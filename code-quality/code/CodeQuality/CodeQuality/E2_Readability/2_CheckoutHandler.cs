using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuality.E2_Readability
{
    public class CheckoutHandler_1
    {

        private Store Store { get; set; }

        public CheckoutState Checkout(List<Product> products)
        {

            foreach (var product in products)
            {

                if (Store.Stock.GetProducts(product.Code).Count() > 0)
                {
                    if (product.Code == "A")
                    {
                        return CheckoutState.MustShowId;
                    }

                    return CheckoutState.Failed;
                }


            }

            return CheckoutState.Completed;

        }
    }
}
