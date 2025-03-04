using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talabat.Core.Entities.Order_Aggregate
{
    public class Order: BaseEntity
    {
        public Order()
        {
        }

        public Order(string buyerEmail, Address shippingAddress, DeliveryMethod deliveryMethod, ICollection<OrderItem> items, decimal subtotal)
        {
            BuyerEmail = buyerEmail;
            ShippingAddress = shippingAddress;
            DeliveryMethod = deliveryMethod;
            Items = items;
            Subtotal = subtotal;
        }

        public string BuyerEmail { get; set; }
        public DateTimeOffset OrderDate { get; set; } = DateTimeOffset.UtcNow;
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
        public Address ShippingAddress { get; set; }   
        //public int? DeliveryMethodId { get; set; }
        public DeliveryMethod? DeliveryMethod { get; set; } //navigation property
        public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>(); //navigation property
        public decimal Subtotal { get; set; }
        
        public decimal GetTotal() => Subtotal + DeliveryMethod.Cost; // Driven attribute
        public string PaymentIntentId { get; set; } = string.Empty;
    }
}
