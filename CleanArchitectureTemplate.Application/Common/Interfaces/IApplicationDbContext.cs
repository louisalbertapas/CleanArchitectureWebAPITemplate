using CleanArchitectureTemplate.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureTemplate.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        public DbSet<Product> Products { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
