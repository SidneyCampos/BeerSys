namespace BeerSys.Entities
{
    class Client
    {
        public string Name { get; set; }
        public int Phone { get; set; }
        public string AdressStreet { get; set; }
        public int AdressNumber { get; set; }
        public int AdressZipCode { get; set; }
        public string AdressAdjunct { get; set; }
        public string AdressState { get; set; }

        public Client(string name, int phone)
        {
            Name = name;
            Phone = phone;
        }
    }
}