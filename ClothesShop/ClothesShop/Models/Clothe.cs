using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothesShop.Models
{
    public class Clothe
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string AvailableSize { get; set; }
        public double Price { get; set; }

        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }
        public Clothe()
        {
            Id = Guid.NewGuid();
        }
    }
}