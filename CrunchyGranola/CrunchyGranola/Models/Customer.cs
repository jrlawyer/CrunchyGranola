using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrunchyGranola.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfLastPurchase { get; set; }

        public virtual ICollection<Product>Products { get; set; }
    }
}