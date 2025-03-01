namespace Talabat.Core.Entities
{
    public class BasketItems
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string ImageUrl { get; set; }
        public string ProductCategory { get; set; }
        public string ProductBrand { get; set; }
        public int Quantity { get; set; }
    }
}