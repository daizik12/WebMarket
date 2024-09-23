using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMarket.models
{
    [Table("category")]
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(32)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(512)]
        public string Description { get; set; } = string.Empty;
        public List<Product>? Products { get; set; }

    }
}
