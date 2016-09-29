namespace XEasyShop.Data.Prototype
{
    using System;
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string IsLock { get; set; }
    }
}
