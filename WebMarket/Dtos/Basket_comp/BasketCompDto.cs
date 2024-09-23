using System.ComponentModel.DataAnnotations;
using WebMarket.Dtos.Product;
using WebMarket.models;

namespace WebMarket.Dtos.Basket_composition
{
    public class BasketCompDto
    {
        public int Id { get; set; }
        [Required]
        public int Quatity { get; set; }
        public int? ProductId { get; set; }
        public string Discription { get; set; } = string.Empty;
    }
}
