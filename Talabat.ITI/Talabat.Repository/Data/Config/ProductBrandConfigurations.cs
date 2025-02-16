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
    internal class ProductBrandConfigurations : IEntityTypeConfiguration<ProductBrand>
    {
        public void Configure(EntityTypeBuilder<ProductBrand> builder)
        {
            builder.Property(pb => pb.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(pb => pb.Description)
                .HasMaxLength(180); 

            //builder.HasIndex(pb => pb.Name)
            //    .IsUnique();
            
        }
    }
}
