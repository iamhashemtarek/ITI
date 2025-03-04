using System.ComponentModel.DataAnnotations;

namespace Talabat.APIs.DTOs
{
    public class BasketItemsDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Range(0.1, double.MaxValue, ErrorMessage = "price must be greater than zero")]
        public decimal Price { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public string ProductCategory { get; set; }
        [Required]
        public string ProductBrand { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "quantity must at least one")]

        public int Quantity { get; set; } 
    }
}