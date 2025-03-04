using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core.Entities.Order_Aggregate;

namespace Talabat.Repository.Data.Config
{
    class OrderItemConfigurations : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.OwnsOne(o => o.Product, p => p.WithOwner());
            builder.Property(o => o.Price).HasColumnType("decimal(18,2)");
        }
    }
}
