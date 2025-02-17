using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Talabat.APIs.DTOs;
using Talabat.APIs.Errors;
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
        private readonly IGenericRepository<ProductBrand> _productBrandRepository;
        private readonly IGenericRepository<ProductCategory> _productCategoryRepository;
        private readonly IMapper _mapper;

        public ProductController(IGenericRepository<Product> productRepository,
            IGenericRepository<ProductBrand> productBrandRepository,
            IGenericRepository<ProductCategory> productCategoryRepository,
            IMapper mapper)
        {
            _productRepo = productRepository;
            _productBrandRepository = productBrandRepository;
            _productCategoryRepository = productCategoryRepository;
            _mapper = mapper;
        }
        [HttpGet]
        public async  Task<ActionResult<IReadOnlyList<Product>>> GetProducts(string? sort, int? brandId, int? categoryId)
        {

            var spec = new ProductWithBrandAndCategorySpecification(sort, brandId, categoryId);
            var products = await _productRepo.GetAllWithSpecAsync(spec);

            if (products.Any())
            {
                return Ok(_mapper.Map<IEnumerable<Product>, IEnumerable<ProductToReturnDto>>(products));
            }
            return NotFound(new ApiResponse(404));
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var spec = new ProductWithBrandAndCategorySpecification(id);
            var product = await _productRepo.GetWithSpecAsync(spec);

            if (product == null) 
                return NotFound(new ApiResponse(404));

            return Ok(_mapper.Map<Product, ProductToReturnDto>(product));
        }

        [HttpGet("brands")]
        public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetBrands()
        {
            var brands = await _productBrandRepository.GetAllAsync();
            if (brands is null)
                return NotFound(new ApiResponse(404));

            return Ok(brands);
        }

        [HttpGet("brands/{id}")]
        public async Task<ActionResult<ProductBrand>> GetBrand(int id)
        {
            var brand = await _productBrandRepository.GetByIdAsync(id);
            if (brand is null)
                return NotFound(new ApiResponse(404));

            return Ok(brand);
        }

        [HttpGet("categories")]
        public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetCategories()
        {
            var categories = await _productCategoryRepository.GetAllAsync();
            if (categories is null)
                return NotFound(new ApiResponse(404));

            return Ok(categories);
        }

        [HttpGet("categories/{id}")]
        public async Task<ActionResult<ProductCategory>> GetCategory(int id)
        {
            var category = await _productCategoryRepository.GetByIdAsync(id);
            if (category is null)
                return NotFound(new ApiResponse(404));

            return Ok(category);
        }
    }
}
