using Dapper.Contrib.Extensions;

namespace CoffeeShop8._3.Models
{
    [Table("product")]
    public class Product
    {
        [Key]
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
