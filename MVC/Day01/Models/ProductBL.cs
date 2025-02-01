namespace Day01.Models
{
    public class ProductBL
    {
        List<Product> products;
        public ProductBL()
        {
            products = new List<Product>()
            {
                new Product() { Id = 1, Name = "product-1", Description = "product-1-description", Price = 100, Category = "category-1", Image= "box.png" },
                new Product() { Id = 2, Name = "product-2", Description = "product-2-description", Price = 200, Category = "category-1", Image= "box.png" },
                new Product() { Id = 3, Name = "product-3", Description = "product-3-description", Price = 300, Category = "category-2", Image= "box.png" },
                new Product() { Id = 4, Name = "product-4", Description = "product-4-description", Price = 400, Category = "category-2", Image= "box.png" },
            };
        }

        public List<Product> GetAll() 
        {
            return products;
        }

        public Product GetByID(int id)
        {
            return products.FirstOrDefault(product => product.Id ==  id);
        }
    }
}
