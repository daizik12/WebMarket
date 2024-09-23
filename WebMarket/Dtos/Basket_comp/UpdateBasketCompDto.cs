using System.ComponentModel.DataAnnotations;
using WebMarket.models;

namespace WebMarket.Dtos.Basket_composition
{
    public class UpdateBasketCompDto
    {
        [Required]
        public int Quatity { get; set; }
        public int? ProductId { get; set; }

        public string? Discription { get; set; } = string.Empty;
    }
}
