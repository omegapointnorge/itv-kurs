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

        public CheckoutState Checkout(List<Product> products, Customer customer)
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

                bool productIsDangerous = product.Code == "EX" || product.Code == "HAZ";
                if (productIsDangerous)
                {
                    NotifyGovernmentOfPurchase(customer);
                }
            }

            return CheckoutState.Completed;

        }

        private void NotifyGovernmentOfPurchase(Customer customer)
        {
            if (customer.WhiteListStatus == "Ok")
            {
                return;
            }

            //Send notification

        }
    }
}
