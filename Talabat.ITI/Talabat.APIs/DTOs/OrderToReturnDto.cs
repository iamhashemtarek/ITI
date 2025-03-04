using Talabat.Core.Entities.Order_Aggregate;

namespace Talabat.APIs.DTOs
{
    public class OrderToReturnDto
    {
        public int Id { get; set; }
        public string BuyerEmail { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public string Status { get; set; }
        public Address ShippingAddress { get; set; }
        public string DeliveryMethod { get; set; }
        public decimal DeliveryMethodCost { get; set; }
        public IReadOnlyList<OrderItemDto> Items { get; set; } = new List<OrderItemDto>();
        public decimal Subtotal { get; set; }
        public string PaymentIntentId { get; set; } = string.Empty;
        public decimal Total { get; set; }   
    }
}
