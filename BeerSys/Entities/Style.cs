namespace BeerSys.Entities
{
    class Style
    {
        public string Name { get; set; }
        public Family Family { get; set; }

        public Style(string name, Family family)
        {
            Name = name;
            Family = family;
        }
    }
}

