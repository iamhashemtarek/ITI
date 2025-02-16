using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Talabat.Core.Entities;
using Talabat.Core.Repositories.Contracts;
using Talabat.Core.Specifications;

namespace Talabat.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IGenericRepository<Product> _productRepo;

        public ProductController(IGenericRepository<Product> productRepository)
        {
            _productRepo = productRepository;
        }
        [HttpGet]
        public async  Task<ActionResult<List<Product>>> GetAll()
        {
            var spec = new ProductWithBrandAndCategorySpecification();
            var products = await _productRepo.GetAllWithSpecAsync(spec);

            if (products.Any())
            {
                return Ok(products);
            }
            return NotFound();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> Get(int id)
        {
            var spec = new ProductWithBrandAndCategorySpecification(id);
            var product = await _productRepo.GetWithSpecAsync(spec);

            if (product == null) 
                return NotFound();

            return Ok(product);
        }
    }
}
