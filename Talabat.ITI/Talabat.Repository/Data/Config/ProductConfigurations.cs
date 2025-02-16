using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core.Entities;

namespace Talabat.Repository.Data.Config
{
    internal class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(180);

            builder.Property(p => p.Price)
                .HasColumnType("decimal(18,2)");

            builder.Property(p => p.ImageUrl)
                .IsRequired()
                .HasMaxLength(250);

            builder.HasOne(b => b.ProductBrand)
                .WithMany()
                .HasForeignKey(p => p.ProductBrandId);

            builder.HasOne(c => c.ProductCategory)
                .WithMany()
                .HasForeignKey(p => p.ProductCategoryId);
            
        }
    }
}
