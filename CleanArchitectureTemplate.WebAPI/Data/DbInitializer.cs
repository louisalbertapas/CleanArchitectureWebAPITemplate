using CleanArchitectureTemplate.WebAPI.Entities;
using Microsoft.AspNetCore.Identity;

namespace CleanArchitectureTemplate.WebAPI.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(ApplicationDbContext applicationDbContext, UserManager<User> userManager)
        {
            // Seed identity table
            if (!userManager.Users.Any())
            {
                var user = new User
                {
                    UserName = "userseed",
                    Email = "userseed@test.com"
                };

                await userManager.CreateAsync(user, "P@ssw0rd1");
                await userManager.AddToRoleAsync(user, "User");

                var admin = new User
                {
                    UserName = "adminseed",
                    Email = "adminseed@test.com"
                };

                await userManager.CreateAsync(admin, "P@ssw0rd1");
                await userManager.AddToRoleAsync(admin, "User");
            }

            // Seed products table
            if (applicationDbContext.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Green Shirt",
                    ProductType = ProductType.Clothes
                },
                new Product
                {
                    Name = "Blue Shirt",
                    ProductType = ProductType.Clothes
                },
                new Product
                {
                    Name = "Red Shirt",
                    ProductType = ProductType.Clothes
                },
                new Product
                {
                    Name = "Green Trousers",
                    ProductType = ProductType.Trousers
                },
                new Product
                {
                    Name = "Blue Trousers",
                    ProductType = ProductType.Trousers
                },
                new Product
                {
                    Name = "Red Trousers",
                    ProductType = ProductType.Trousers
                }
            };

            foreach (var product in products)
                applicationDbContext.Products.Add(product);

            await applicationDbContext.SaveChangesAsync();
        }
    }
}
