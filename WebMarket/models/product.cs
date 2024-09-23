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
        public int Id { get; set; }
        [Required, MaxLength(32)]
        public string Name { get; set; } = string.Empty;
        [Required]
        public int Quantity {  get; set; }
        [Required, Column(TypeName = "decimal(18,2")]
        public int Price { get; set; }
        [MaxLength(512)]
        public string Discription { get; set; } = string.Empty;
        public int? ManufacturerId { get; set; }
        public Manufacturer? Manufacturer { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public List<Basket_composition> Basket_Compositions { get; set; } = new List<Basket_composition>();
    }
}
