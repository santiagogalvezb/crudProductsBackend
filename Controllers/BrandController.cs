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
    public class BrandController : ControllerBase
    {
        private DjCatalogDbContext _dbContext;
        public BrandController(DjCatalogDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Brand>>> Get()
        {
            return await _dbContext.Brand.AsNoTracking().ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<Brand>> CreateBrand(
            [FromBody] Brand brand
        )
        {
            _dbContext.Brand.Add(brand);
            await _dbContext.SaveChangesAsync();
            return StatusCode(201, brand);
        }
    }
}
