using System.Net.Http.Headers;

namespace supermarket.API.Domain.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        // has many products
        public IList<Product> Products { get; set; } = new List<Product>();
    }
}
