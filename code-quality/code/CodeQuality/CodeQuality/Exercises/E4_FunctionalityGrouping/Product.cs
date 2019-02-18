using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuality.E4_FunctionalityGrouping
{
    public class Product
    {

        public string Code { get; set; }
        public string Price { get; set; }
        public string Name { get; set; }
        public int NumberOfTimesSold { get; set; }
        public int NumbersInStock { get; set; }
        private DateTime LastPurchasedAt { get; set; }
        private Supplier Supplier { get; set; }


        public bool IsInStock()
        {
            return NumbersInStock > 0;
        }

        public DateTime LatestPurchase()
        {
            return LastPurchasedAt;
        }

        public void Buy()
        {
            NumberOfTimesSold++;
            NumbersInStock--;
            LastPurchasedAt = DateTime.Now;
        }

        public void OrderMoreStockFromSupplier(int quantity)
        {
            Supplier.Order(Code, quantity);
        }


    }
}
