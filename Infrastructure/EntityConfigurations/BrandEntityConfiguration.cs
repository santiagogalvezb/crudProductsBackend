using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using net_api_swagger.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_api_swagger.Infrastructure.EntityConfigurations
{
    public class BrandEntityConfiguration: IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> configuration)
        {
            configuration.HasKey(brand => brand.Id);
            configuration.Property(brand => brand.Name)
            .HasMaxLength(30)
            .IsRequired();
        }
    }
}
