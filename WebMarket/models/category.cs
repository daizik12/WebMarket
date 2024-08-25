using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMarket.models
{
    [Table("category")]
    public class Category
    {
        [Key]
        public int id { get; set; }
        [MaxLength(32)]
        public string name { get; set; } = string.Empty;
        [MaxLength(512)]
        public string description { get; set; } = string.Empty;
        public List<Product>? products { get; set; }

    }
}
