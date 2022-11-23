using CleanArchitectureTemplate.Domain.Entities;
using CleanArchitectureTemplate.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CleanArchitectureTemplate.Infrastructure.Persistence.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);

            // Seed identity roles
            builder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole { Name = "SuperAdmin", NormalizedName = "SUPERADMIN" },
                    new IdentityRole { Name = "User", NormalizedName = "USER" }
                );
        }
    }
}
