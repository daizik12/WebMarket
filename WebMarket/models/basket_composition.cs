using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMarket.models
{
    public class Basket_composition
    {
        public int Id { get; set; }
        [Required]
        public int Quatity { get; set; }
        [MaxLength(512)]
        public string Discription { get; set; } = string.Empty;
        //public User? userid { get; set; }
        public int? ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
