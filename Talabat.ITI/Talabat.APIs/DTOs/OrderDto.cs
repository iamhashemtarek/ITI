﻿using System.ComponentModel.DataAnnotations;
using Talabat.Core.Entities.Order_Aggregate;

namespace Talabat.APIs.DTOs
{
    public class OrderDto
    {
        //string buyerEmail, string basketId, int deliveryMethodId, Address shippingAddress
        [Required]
        public string BuyerEmail { get; set; }
        [Required]
        public string BasketId { get; set; }
        [Required]
        public int DeliveryMethodId { get; set; }
        public AddressDto ShippingAddress { get; set; }
    }
}
