using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Talabat.APIs.DTOs;
using Talabat.APIs.Errors;
using Talabat.Core.Entities;
using Talabat.Core.Repositories.Contracts;
using Talabat.Core.Services.Contracts;
using Talabat.Core.Specifications;

namespace Talabat.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        
        private readonly IMapper _mapper;
        private readonly IProductService _productService;

        public ProductController(IMapper mapper, IProductService productService)
        {
            _mapper = mapper;
            _productService = productService;
        }

        [Authorize]
        [HttpGet]
        public async  Task<ActionResult<IReadOnlyList<Product>>> GetProducts([FromQuery] ProductSpecParams productSpec)
        {

            var products = await _productService.GetProductsAsync(productSpec);
            if (products.Any())
            {
                return Ok(_mapper.Map<IEnumerable<Product>, IEnumerable<ProductToReturnDto>>(products));
            }
            return NotFound(new ApiResponse(404));
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _productService.GetProductByIdAsync(id);

            if (product == null) 
                return NotFound(new ApiResponse(404));

            return Ok(_mapper.Map<Product, ProductToReturnDto>(product));
        }

        [HttpGet("brands")]
        public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetBrands()
        {
            var brands = await _productService.GetProductBrandsAsync();
            if (brands is null)
                return NotFound(new ApiResponse(404));

            return Ok(brands);
        }

        //[HttpGet("brands/{id}")]
        //public async Task<ActionResult<ProductBrand>> GetBrand(int id)
        //{
        //    var brand = await _productBrandRepository.GetByIdAsync(id);
        //    if (brand is null)
        //        return NotFound(new ApiResponse(404));

        //    return Ok(brand);
        //}

        [HttpGet("categories")]
        public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetCategories()
        {
            var categories = await _productService.GetProductCategoriesAsync();
            if (categories is null)
                return NotFound(new ApiResponse(404));

            return Ok(categories);
        }

        //[HttpGet("categories/{id}")]
        //public async Task<ActionResult<ProductCategory>> GetCategory(int id)
        //{
        //    var category = await _productCategoryRepository.GetByIdAsync(id);
        //    if (category is null)
        //        return NotFound(new ApiResponse(404));

        //    return Ok(category);
        //}
    }
}
