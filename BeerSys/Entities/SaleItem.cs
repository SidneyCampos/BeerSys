namespace BeerSys.Entities
{
    class SaleItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public SaleItem(Product product, int quantity)
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

        public double subTotal()
        {
            return Product.Price * Quantity;
        }
    }
}