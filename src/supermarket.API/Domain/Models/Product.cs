namespace supermarket.API.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short QuantityInPackage { get; set; }
        public EUnitOfMeasurement UnitOfMeasurement { get; set; }
        // forgein key
        public int CategoryId { get; set; }
        // has one category
        public Category Category { get; set; }
    }
}