using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMarket.models
{
    [Table("orders")]
    public class Order
    {
        [Key]
        public int id { get; set; }
        [Required]
        public DateTime open { get; set; }
        [Required]
        public DateTime close { get; set; }
        [MaxLength(512)]
        public string discription { get; set; } = string.Empty;
        public Basket? basketid { get; set; }
        public User? userid { get; set; }
    }
}
