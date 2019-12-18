using ClothesShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace ClothesShop.DatabaseContext
{
    public class BaseInitializer : DropCreateDatabaseIfModelChanges<BaseContext>
    {
        protected override void Seed(BaseContext context)
        {
            context.Clothes.AddOrUpdate(
                x => x.Name,
                new Clothe
                {
                    Name="T-shirt Miami",
                    Category="Men,Kids",
                    AvailableSize="XS,S,M,L",
                    Price=21.99
                },
                new Clothe
                {
                    Name = "Shirt",
                    Category = "Men",
                    AvailableSize = "M,L,XL,XXL",
                    Price = 33.21
                },
                new Clothe
                {
                    Name = "Evening dress",
                    Category = "Women",
                    AvailableSize = "XS,S,M,L",
                    Price = 45.02
                },
                new Clothe
                {
                    Name = "Pajamas",
                    Category = "Women",
                    AvailableSize = "XS,S,M",
                    Price = 19.49
                },
                new Clothe
                {
                    Name = "Pants",
                    Category = "Kids",
                    AvailableSize = "XS,S",
                    Price = 33.40
                },
                new Clothe
                {
                    Name = "Jacket",
                    Category = "Men",
                    AvailableSize = "M,L,XL",
                    Price = 52.33
                }
                );
        }

    }
}