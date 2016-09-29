using System;
using System.Collections.Generic;

namespace XEasyShop.Data.Prototype.Fuctional
{
    public class Category
    {
        public Guid Id { get; set; }
        public Category RootCategory { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
