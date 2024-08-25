using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMarket.models
{
    [Table("users")]
    public class User
    {
        public int id { get; set; }
        public string name { get; set; } = string.Empty;
        public string family { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string phone { get; set; } = string.Empty;
        public string num_card { get; set; } = string.Empty;
        public List<Basket>? baskets { get; set; }
        public List<Order>? orders { get; set; }
    }
}
