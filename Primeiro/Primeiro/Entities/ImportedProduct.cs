using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Primeiro.Entities
{
    class ImportedProduct : Products
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return Name 
                + " $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Custom fee: $ "
                + CustomsFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }
    }
}
