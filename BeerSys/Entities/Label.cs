namespace BeerSys.Entities.Enums
{
    class Label
    {
        public string Name { get; set; }
        public Brand Brand { get; set; }

        public Style Style { get; set; }

        public Label(string name, Brand brand, Style style)
        {
            Name = name;
            Brand = brand;
            Style = style;
        }

        public Label(string name, Brand brand)
        {
            Name = name;
            Brand = brand;
        }
    }
}