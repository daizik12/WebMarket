using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMarket.models
{
    public class Basket_composition
    {
        public int id { get; set; }
        [Required]
        public int quatity { get; set; }
        [MaxLength(512)]
        public string discription { get; set; } = string.Empty;
        //public User? userid { get; set; }
        public Product? productid { get; set; }
    }
}
