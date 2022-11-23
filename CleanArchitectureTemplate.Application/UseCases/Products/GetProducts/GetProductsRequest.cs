using MediatR;
using CleanArchitectureTemplate.Domain.Entities;

namespace CleanArchitectureTemplate.Application.UseCases.Products.GetProducts
{
    public class GetProductsRequest : IRequest<List<Product>>
    {
        public GetProductsRequest()
        {

        }
    }
}
