using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Models
{
    public class ProductReturnDto
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Required]
        public string BrandName { get; set; }

        [Required]
        public string CategoryName { get; set; }
    }
}
