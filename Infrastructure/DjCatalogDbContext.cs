using Microsoft.EntityFrameworkCore;
using net_api_swagger.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_api_swagger.Infrastructure
{
    public class DjCatalogDbContext : DbContext
    {
        public DjCatalogDbContext(DbContextOptions<DjCatalogDbContext> options) : base(options)
        {


        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Product> Product { get; set; }

    }
}
