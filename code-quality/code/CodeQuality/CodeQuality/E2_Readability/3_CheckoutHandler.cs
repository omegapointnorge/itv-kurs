using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuality.E2_Readability
{
    public class CheckoutHandler_3
    {

        private Store Store { get; set; }

        public decimal GetTotalPriceOfCart(List<CartElement> cartElements, Customer customer)
        {

            var totalPrice = 0m;
            foreach (var cartElement in cartElements)
            {
                var price = cartElement.Product.PriceHistory.Where(x => x.ActiveFrom < DateTime.UtcNow && x.ActiveTo < DateTime.UtcNow).First();
                var priceToUse = price.Price;
                if (price.Discount > 0)
                {
                    var price2 = price.Discount * price.Price;

                    if (price.AmountMinLimitForDiscountToApply > cartElement.Quantity)
                    {
                        totalPrice += price.Price;
                        continue;
                    }
                    totalPrice += price.Price;
                }
            }


            if (customer.Age > 65 && customer.NumberOfYearsAsClient > 10)
            {
                return totalPrice * 0.9m;
            }

            return totalPrice;

        }
    }
}
