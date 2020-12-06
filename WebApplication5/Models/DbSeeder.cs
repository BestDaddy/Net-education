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
            if (!context.Roles.Any())
            {
                context.Roles.AddRange(
                    new Role
                    {
                        Id = 1,
                        Name = "Admin"
                       
                    },
                    new Role
                    {
                        Id = 2,
                        Name = "User"
                        
                    }
                );
                context.SaveChanges();
            }
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User
                    {
                        Id = 1,
                        Name = "AdminUser",
                        Email = "admin@mail.ru",
                        Password = "asdf123",
                        Role_id = 1,
                    },
                    new User
                    {
                        Id = 2,
                        Name = "UserUser",
                        Email = "user@mail.ru",
                        Password = "asdf123",
                        Role_id = 2,

                    }
                );
                context.SaveChanges();
            }
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
