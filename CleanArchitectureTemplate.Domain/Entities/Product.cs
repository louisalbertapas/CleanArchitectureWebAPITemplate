#nullable disable
using System.ComponentModel.DataAnnotations;

namespace CleanArchitectureTemplate.Domain.Entities
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public ProductType ProductType { get; set; }
    }
}
