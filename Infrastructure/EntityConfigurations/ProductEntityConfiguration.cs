using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using net_api_swagger.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_api_swagger.Infrastructure.EntityConfigurations
{
    public class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> configuration)
        {
            configuration.HasKey(product => product.Id);
            configuration.Property(product => product.Name)
            .HasMaxLength(30)
            .IsRequired();
            configuration.Property(product => product.Stock)
            .HasMaxLength(5)
            .IsRequired();
            configuration.Property<Guid>("CategoryId")
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("CategoryId")
            .IsRequired();
            configuration.HasOne(product => product.Category)
              .WithMany()
              .HasForeignKey("CategoryId");
            configuration.Property<Guid>("BrandId")
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("BrandId")
            .IsRequired();
            configuration.HasOne(product => product.Brand)
              .WithMany()
              .HasForeignKey("BrandId");
        }
    }
}
