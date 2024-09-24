using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebMarket.models;
using WebMarket.Dtos.Basket_composition;

namespace WebMarket.Dtos.Product
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int? ManufacturerId { get; set; }
        public int? CategoryId { get; set; }
        public List<BasketCompDto> BasketCompositions { get; set; } = new List<BasketCompDto>();
    }
}
