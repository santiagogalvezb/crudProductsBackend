using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using net_api_swagger.Domain;
using net_api_swagger.Infrastructure;

namespace net_api_swagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private DjCatalogDbContext _dbContext;

        public ProductController(DjCatalogDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> Get()
        {
            await Task.Delay(5000);
            return await _dbContext.Product.AsNoTracking().ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<Product>> CreateProduct(
            [FromBody] Product product
        )
        {
            _dbContext.Product.Add(product);
            await _dbContext.SaveChangesAsync();
            return StatusCode(201, product);
        }
    }
}
