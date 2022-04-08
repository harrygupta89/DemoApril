using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcAndOopsFundamentals.model
{
    public class Offer
    {
        public string OfferName { get; set; }
        public List<Product> Products { get; set; }

        public Offer(string _offerName, decimal _price , List<Product> _products)
        {
            OfferName = _offerName;
            Products = _products;
        }

    }
}