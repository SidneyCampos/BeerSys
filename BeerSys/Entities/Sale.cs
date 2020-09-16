using System;
using System.Collections.Generic;
namespace BeerSys.Entities
{
    class Sale
    {
        public List<SaleItem> Itens { get; set; } = new List<SaleItem>();
        public Client Client { get; set; }

        public DateTime Date { get; set; }

        public Sale(Client client, DateTime date)
        {
            Client = client;
            Date = date;
        }

        public void AddSaleItem(SaleItem Item)
        {


        }

        public void RemoveSaleItem(SaleItem Item)
        {

        }
    }
}