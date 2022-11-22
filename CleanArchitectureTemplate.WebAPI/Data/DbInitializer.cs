using CleanArchitectureTemplate.WebAPI.Entities;

namespace CleanArchitectureTemplate.WebAPI.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext applicationDbContext)
        {
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

            applicationDbContext.SaveChanges();
        }
    }
}
