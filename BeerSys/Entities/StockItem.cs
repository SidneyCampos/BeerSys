namespace BeerSys.Entities
{
    class StockItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public StockItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public void QuantitySum(int amount)
        {
            Quantity += amount;
        }

        public void QuantitySubstract(int amount)
        {
            Quantity -= amount;
        }
    }
}