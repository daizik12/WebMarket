using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebMarket.models
{
    [Table("basket")]
    public class Basket
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Address { get; set; } = string.Empty;
        [MaxLength(512)]
        public string Discription { get; set; } = string.Empty;
        public User? User { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();

    }
}
