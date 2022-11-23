using CleanArchitectureTemplate.Application.Common.Interfaces;
using CleanArchitectureTemplate.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureTemplate.Application.UseCases.Products.GetProducts
{
    internal class GetProductsRequestHandler : IRequestHandler<GetProductsRequest, List<Product>>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public GetProductsRequestHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<Product>> Handle(GetProductsRequest request, CancellationToken cancellationToken)
        {
            return await _applicationDbContext.Products.ToListAsync();
        }
    }
}
