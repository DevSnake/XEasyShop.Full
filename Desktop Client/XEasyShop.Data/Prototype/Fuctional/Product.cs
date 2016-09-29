using System;
using System.Collections.Generic;

namespace XEasyShop.Data.Prototype.Fuctional
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Article { get; set; } 
        public ICollection<ExchangeRate> ExchangeRates { get; set; }

        public Product()
        {
            ExchangeRates=new List<ExchangeRate>();
        }
    }
}
