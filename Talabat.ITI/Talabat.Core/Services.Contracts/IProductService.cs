using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core.Entities;
using Talabat.Core.Specifications;

namespace Talabat.Core.Services.Contracts
{
    public interface IProductService
    {
        Task<IReadOnlyList<Product>> GetProductsAsync(ProductSpecParams productSpec);
        Task<Product> GetProductByIdAsync(int id);
        Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync();
        Task<IReadOnlyList<ProductCategory>> GetProductCategoriesAsync();


        //Task<Product> CreateProductAsync(Product product);
        //Task<Product> UpdateProductAsync(Product product);
        //Task DeleteProductAsync(int id);
    }
}
