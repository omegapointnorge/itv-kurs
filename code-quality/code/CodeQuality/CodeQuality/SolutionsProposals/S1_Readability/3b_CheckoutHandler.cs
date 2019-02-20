using CodeQuality.E1_Readability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuality.S1_Readability
{
    public class CheckoutHandler_3
    {
        private const decimal SeniorDiscountRate = 0.9m;

        private ClientRegistry Store { get; set; }

        public decimal GetTotalPriceOfCart(List<CartElement> cartElements, Customer customer)
        {
            var priceCalculator = new PriceCalculator();
            var totalPrice = 0m;

            foreach (var cartElement in cartElements)
            {
                totalPrice += priceCalculator.GetPriceOfProduct(cartElement);
            }

            return CustomerIsEligibleForSeniorDiscount(customer) ?
             totalPrice * SeniorDiscountRate :
             totalPrice;
        }

        private bool CustomerIsEligibleForSeniorDiscount(Customer customer)
        {
            return customer.Age > 65 && customer.NumberOfYearsAsClient > 10;
        }
    }

    public class PriceCalculator
    {
        public decimal GetPriceOfProduct(CartElement cartElement)
        {
            var priceDataForCurrentDate = GetCurrentPriceData(cartElement.Product.Id);
            var fullprice = priceDataForCurrentDate.FullPrice;

            bool priceHasDiscount = priceDataForCurrentDate.Discount > 0;
            bool eligibleForDiscount = IsDiscountQuantityRequirementFulfilled(cartElement.Quantity, priceDataForCurrentDate.AmountMinLimitForDiscountToApply);

            return (priceHasDiscount && eligibleForDiscount) ? fullprice * priceDataForCurrentDate.Discount : fullprice;
        }

        private bool IsDiscountQuantityRequirementFulfilled(int quantity, int limit)
        {
            return limit >= quantity;
        }

        private PriceHistoryElement GetCurrentPriceData(int productId)
        {
            throw new NotImplementedException();
        }
    }
}

