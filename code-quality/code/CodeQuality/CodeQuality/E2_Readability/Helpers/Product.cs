using System.Collections.Generic;

namespace CodeQuality.E2_Readability
{
    public class Product
    {
        public string Code { get; internal set; }
        public IEnumerable<PriceHistoryElement> PriceHistory { get; internal set; }
    }
}