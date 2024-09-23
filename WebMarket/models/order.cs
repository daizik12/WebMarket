using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMarket.models
{
    [Table("orders")]
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Open { get; set; }
        [Required]
        public DateTime Close { get; set; }
        [MaxLength(512)]
        public string Discription { get; set; } = string.Empty;
        public Basket? Basket { get; set; }
        public User? User { get; set; }
    }
}
