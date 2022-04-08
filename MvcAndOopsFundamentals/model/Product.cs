using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcAndOopsFundamentals.model
{
    public class Product
    {
        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public Product(string _productName, decimal _price ,  string _description)
        {
            ProductName = _productName;
            Price = _price;
            Description = _description;
        }

    }
}
