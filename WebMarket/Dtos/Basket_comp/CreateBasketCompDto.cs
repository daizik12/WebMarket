using WebMarket.models;

namespace WebMarket.Dtos.Basket_composition
{
    public class CreateBasketCompDto
    { 
        public int Quatity { get; set; }
        public int? ProductId { get; set; }
        public string Discription { get; set; } = string.Empty;
    }
}
