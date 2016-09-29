


using XEasyShop.Data.Prototype;
using XEasyShop.Data.Prototype.Fuctional;

namespace XEasyShop.Data
{
    using  System.Data.Entity;
    public class DataContext:DbContext
    {
        #region Propotype

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        //public DbSet<Colour> Colours { get; set; }
        //public DbSet<Composition> Compositions { get; set; }
        public DbSet<ExchangeRate> ExchangeRates { get; set; }
        public DbSet<Сurrency> Сurrencies { get; set; }
        //public DbSet<Manufacturer> Manufacturers { get; set; }
        //public DbSet<Price> Prices { get; set; }
        //public DbSet<Size> Sizes { get; set; }
        //public DbSet<СlothingType> СlothingTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Rule> Rules { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Customer> Customers { get; set; }

        #endregion


        public DataContext():base("Default")
        {  
        }

    }
}
