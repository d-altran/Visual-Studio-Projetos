using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Primeiro.Entities
{
    class Products
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Products()
        {

        }
        public Products(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return Name 
               + " $ " 
               + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
