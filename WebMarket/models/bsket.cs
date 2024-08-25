using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebMarket.models
{
    [Table("basket")]
    public class Basket
    {
        [Key]
        public int id { get; set; }
        [MaxLength(100)]
        public string address {  get; set; } = string.Empty;
        [MaxLength(512)]
        public string discription {  get; set; } = string.Empty;
        public User? user { get; set; }
        public List<Order>? orders { get; set; }

    }
}
