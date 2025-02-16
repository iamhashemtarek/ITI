using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Talabat.APIs.Errors;
using Talabat.Repository.Data;

namespace Talabat.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuggyController : ControllerBase
    {
        private readonly StoreContext _storeContext;

        public BuggyController(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }

        [HttpGet("NotFound")]
        public ActionResult GetNotFoundResponse()
        {
            var product = _storeContext.Products.Find(100);
            if (product is null) 
                return NotFound(new ApiResponse(404));

            return Ok(product);
        }

        [HttpGet("BadRequest")]
        public ActionResult GetBadRequestResponse() 
        {
            return BadRequest(new ApiResponse(400));        
        }

        [HttpGet("ServerError")]
        public ActionResult GetServerErrorResponse()
        {
            var product = _storeContext.Products.Find(100);
            var productToReturn = product.ToString();
            return Ok(productToReturn);
        }

        [HttpGet("ValidationError/{id}")]
        public ActionResult GetValidationErrorResponse(int id) 
        {
            return Ok();        
        }

        [HttpGet("Unauthorized")] 
        public ActionResult GetUnauthorizedResponse()
        {
            return Unauthorized(new ApiResponse(401));
        }

    }
}
