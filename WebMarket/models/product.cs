using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebMarket.models
{
    [Table("product")]
    public class Product
    {
        [Key]
        public int id { get; set; }
        [Required, MaxLength(64)]
        public string name { get; set; } = string.Empty;
        [Required]
        public int quantity {  get; set; }
        [Required, Column(TypeName = "decimal(18,2")]
        public int price { get; set; }
        [MaxLength(512)]
        public string discription { get; set; } = string.Empty;
        public Manufacturer? manufacturerid { get; set; }
        public Category? categoryid { get; set; }
        public List<Basket_composition>? basket_Compositions { get; set; }
    }
}
