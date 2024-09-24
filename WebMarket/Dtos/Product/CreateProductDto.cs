using System.ComponentModel.DataAnnotations;
using WebMarket.models;

namespace WebMarket.Dtos.Product
{
    public class CreateProductDto
    {
        [Required, MaxLength(32, ErrorMessage = "Name cannot be over 10 over characters")]
        public string Name { get; set; } = string.Empty;
        [Required, Range(0, 100000)]
        public int Quantity { get; set; }
        [Required, Range(1, 10000000)]
        public int Price { get; set; }
        [Required]
        public int? ManufacturerId { get; set; }
        [Required]
        public int? CategoryId { get; set; }
    }
}
