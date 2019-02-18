using System;

namespace CodeQuality.S4_FunctionalityGrouping
{
    public class Product
    {
        public string Code { get; set; }
        public string Price { get; set; }
        public string Name { get; set; }
        private Supplier Supplier { get; set; }
    }

    public class Store
    {
        public Stock Stock { get; set; }
        public StoreStatistics Statistics { get; set; }
        public OutgoingOrderHandler OutgoingOrderHandler { get; set; }

        public void ProcessPurchaseOrder(int productId, int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount must be over 0");
            }

            Stock.DecreaseStockOfProduct(productId, amount);
            Statistics.UpdateLastPurchasedForProduct(productId);
        }

        public void OrderProduct(int productId, int quantity)
        {
            var supplier = GetSupplierOfProduct(productId);
            var order = OutgoingOrderHandler.SendOrder(supplier, productId, quantity);
        }

        private Supplier GetSupplierOfProduct(int productId)
        {
            throw new NotImplementedException();
        }
    }

    public class OutgoingOrderHandler
    {
        internal object SendOrder(Supplier supplier, int productId, int quantity)
        {
            throw new NotImplementedException();
        }
    }

    public class Supplier
    {
    }

    public class StoreStatistics
    {

        public int NumberOfTimesSold { get; set; }
        private DateTime LastPurchasedAt { get; set; }

        internal void UpdateLastPurchasedForProduct(int productId)
        {
            throw new NotImplementedException();
        }
    }

    public class Stock
    {
        public bool ProductIsInStock(int productId)
        {
            return NumberOfProductsInStock(productId) > 0;
        }

        private int NumberOfProductsInStock(int productId)
        {
            throw new NotImplementedException();
        }

        internal void DecreaseStockOfProduct(int productId, int amount)
        {
            throw new NotImplementedException();
        }
    }
}
