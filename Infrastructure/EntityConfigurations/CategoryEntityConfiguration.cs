using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using net_api_swagger.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_api_swagger.Infrastructure.EntityConfigurations
{
    public class CategoryEntityConfiguration: IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> configuration)
        {
            configuration.HasKey(category => category.Id);
            configuration.Property(category => category.Name)
            .HasMaxLength(30)
            .IsRequired();
            configuration.Property(category => category.Description)
            .HasMaxLength(100)
            .IsRequired();
        }
    }
}
