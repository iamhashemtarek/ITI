using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using myspace.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myspace.Configurations
{
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments");

            builder.HasKey(e => e.Id);
            builder.Property(d => d.Id)
                .UseIdentityColumn(1, 1);

            builder.Property(d => d.Name)
                .IsRequired(true)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .HasColumnName("dept_name")
                .HasDefaultValue("test");

            builder.Property(d => d.Created)
                .HasComputedColumnSql("GETDATE()");

        }
    }
}
