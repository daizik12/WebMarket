using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMarket.models
{
    [Table("users")]
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Family { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Num_card { get; set; } = string.Empty;
        public List<Basket>? Baskets { get; set; }
        public List<Order>? Orders { get; set; }
    }
}
