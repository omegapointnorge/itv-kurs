using System.Collections.Generic;

namespace CodeQuality.E1_Readability
{
    public class Product
    {
        public string Code { get; internal set; }
        public int Id { get; internal set; }
        public IEnumerable<PriceHistoryElement> PriceHistory { get; internal set; }
    }
}