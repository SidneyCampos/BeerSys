using BeerSys.Entities.Enums;
namespace BeerSys.Entities
{
    class Product
    {
        public Label Label { get; set; }

        public Vessel Vessel { get; set; }

        public double Price { get; set; }

        public double Volume { get; set; }

        public Product(Label label, Vessel vessel, double price, double volume)
        {
            Label = label;
            Vessel = vessel;
            Price = price;
            Volume = volume;
        }
    }
}