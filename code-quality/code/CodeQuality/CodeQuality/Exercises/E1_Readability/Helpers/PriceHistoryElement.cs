using System;

namespace CodeQuality.E1_Readability
{
    public class PriceHistoryElement
    {
        public DateTime ActiveFrom { get; set; }
        public DateTime ActiveTo { get; set; }
        public decimal FullPrice { get; set; }
        public decimal Discount { get; set; }
        public int AmountMinLimitForDiscountToApply { get; set; }
    }
}