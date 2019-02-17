using System;

namespace CodeQuality.E2_Readability
{
    public class PriceHistoryElement
    {
        public DateTime ActiveFrom { get; set; }
        public DateTime ActiveTo { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public int AmountMinLimitForDiscountToApply { get; set; }
    }
}