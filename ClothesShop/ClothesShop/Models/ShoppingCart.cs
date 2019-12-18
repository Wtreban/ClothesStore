using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothesShop.Models
{
    public class ShoppingCart
    {
        public Guid Id { get; set; }
        public double Sum { get; set; }
        public DateTime DateCreated { get; private set; }
        public Boolean Paid { get; set; }
        public virtual ICollection<Clothe> Items { get; set; }

        public ShoppingCart()
        {
            Id = Guid.NewGuid();
            Sum = 0;
            DateCreated = DateTime.Now;
            Items = new List<Clothe>();
            Paid = false;

        }

        public void AddToCart(Clothe clothe)
        {

            Items.Add(clothe);
            Sum += clothe.Price;
        }
    }
}