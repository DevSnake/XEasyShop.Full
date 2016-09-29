using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XEasyShop.Data.Prototype
{
    public class UserProfile
    {
        [Key]
        [ForeignKey("User")]
        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public User User { get; set; }
    }
}
