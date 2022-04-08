using MvcAndOopsFundamentals.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcAndOopsFundamentals.services
{
    public class OfferService
    {
        private List<Product> Inventory { get; set; }

        private List<Product> add()
        {
            Inventory.Add(new Product("P1", 1000, "P1 Desc"));
            Inventory.Add(new Product("P2", 200, "P2 Desc"));
            Inventory.Add(new Product("P3", 400, "P3 Desc"));
            Inventory.Add(new Product("P4", 700, "P4 Desc"));
            Inventory.Add(new Product("P4", 600, "P5 Desc"));
            Inventory.Add(new Product("P5", 800, "P6 Desc"));

            return Inventory;
        }

        public OfferService()
        {
            add();
        }

        public List<Product>  GetAllProducts()
        {
            return Inventory;      
        }

        public List<Product>  GetTodaysOffers()
        {
            return Inventory;
        }

    }
}
