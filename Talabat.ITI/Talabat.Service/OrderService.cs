using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core;
using Talabat.Core.Entities;
using Talabat.Core.Entities.Order_Aggregate;
using Talabat.Core.Repositories.Contracts;
using Talabat.Core.Services.Contracts;
using Talabat.Core.Specifications;

namespace Talabat.Service
{
    public class OrderService : IOrderService
    {
        private readonly ICustomerBasketRepository _customerBasketRepository;
        private readonly IUnitOfWork _unitOfWork;

        public OrderService(ICustomerBasketRepository customerBasketRepository, IUnitOfWork unitOfWork)
        {
            _customerBasketRepository = customerBasketRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Order?> CreateOrderAsync(string buyerEmail, string basketId, int deliveryMethodId, Address shippingAddress)
        {
            // get basket from baskets repo
            var basket = await _customerBasketRepository.GetBasketAsync(basketId);

            // get items from product repo
            var orderItems = new List<OrderItem>();
            if (basket?.Items?.Count > 0)
            {
                var productRepo = _unitOfWork.Repository<Product>();
                foreach (var item in basket.Items)
                {
                    var product = await productRepo.GetByIdAsync(item.Id);
                    var productItemOrdered = new ProductItemOrdered(item.Id, item.Name, item.ImageUrl);
                    var orderItem = new OrderItem(productItemOrdered, product.Price, item.Quantity);

                    orderItems.Add(orderItem);
                }
            }

            // get delivery method from repo
            var deliveryMethod = await _unitOfWork.Repository<DeliveryMethod>().GetByIdAsync(deliveryMethodId);

            // calc subtotal
            var subtotal = orderItems.Sum(item => item.Quantity * item.Price);

            // create order
            var order = new Order(buyerEmail, shippingAddress, deliveryMethod, orderItems, subtotal);
            await _unitOfWork.Repository<Order>().AddAsync(order);

            // save to db
            var result = await _unitOfWork.SaveChangesAsync();
            if (result <= 0)
                return null;
            return order;
        }

        public Task<IReadOnlyList<Order>> GerOrdersForUserAsync(string buyerEmail)
        {
            var spec = new OrderSpecifications(buyerEmail);
            var orders = _unitOfWork.Repository<Order>().GetAllWithSpecAsync(spec);
            return orders;
        }

        public Task<Order> GetOrderByIdForUserAsync(int orderId, string buyerEmail)
        {
            var spec = new OrderSpecifications(orderId, buyerEmail);
            var order = _unitOfWork.Repository<Order>().GetWithSpecAsync(spec);
            return order;
        }

        public async Task<IReadOnlyList<DeliveryMethod>> GetDeliveryMethodsAsync()
        {
            var deliveryMethods = await _unitOfWork.Repository<DeliveryMethod>().GetAllAsync();
            return deliveryMethods;
        }
    }
}
