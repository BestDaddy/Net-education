using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public static class DbSeeder
    {
        public static void Initialize(MobileContext context)
        {
            if (!context.Items.Any())
            {
                context.Items.AddRange(
                    new Item
                    {
                        Title = "Car",
                        Decription = "BMW",
                        Price = 100
                    },
                    new Item
                    {
                        Title = "Computer",
                        Decription = "i5 GTX1660s",
                        Price = 14
                    },
                    new Item
                    {
                        Title = "Thing",
                        Decription = "idk",
                        Price = 5666
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
