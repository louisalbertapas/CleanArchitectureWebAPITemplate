using CleanArchitectureTemplate.WebAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureTemplate.WebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
