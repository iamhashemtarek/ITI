using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Talabat.APIs.DTOs;
using Talabat.APIs.Errors;
using Talabat.Core.Entities.Order_Aggregate;
using Talabat.Core.Services.Contracts;

namespace Talabat.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public OrdersController(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<Order>> CreateOrder(OrderDto orderDto)
        {
            var address = _mapper.Map<AddressDto, Address>(orderDto.ShippingAddress);
            var order = await _orderService.CreateOrderAsync(orderDto.BuyerEmail, orderDto.BasketId, orderDto.DeliveryMethodId, address);

            if(order == null) return BadRequest(new ApiResponse(400));
            return Ok(order);
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<Order>>> GetOrdersForUser(string buyerEmail)
        {
            var orders = await _orderService.GerOrdersForUserAsync(buyerEmail);
            if (orders == null) return NotFound(new ApiResponse(404));
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrderByIdForUser(int id, string buyerEmail)
        {
            var order = await _orderService.GetOrderByIdForUserAsync(id, buyerEmail);
            if (order == null) return NotFound(new ApiResponse(404));
            return Ok(order);
        }
    }
}
