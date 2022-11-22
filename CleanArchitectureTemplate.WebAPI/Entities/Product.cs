#nullable disable
using System.ComponentModel.DataAnnotations;

namespace CleanArchitectureTemplate.WebAPI.Entities
{
    public class Product
    {
        public long Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public ProductType ProductType { get; set; }
    }
}
