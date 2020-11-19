using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using net_api_swagger.Domain;
using net_api_swagger.Infrastructure;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace net_api_swagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private DjCatalogDbContext _dbContext;

        public CategoryController(DjCatalogDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> Get()
        {
            await Task.Delay(5000);
            return await _dbContext.Category.AsNoTracking().ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<Category>> CreateCategory(
            [FromBody] Category category
        )
        {
            _dbContext.Category.Add(category);
            await _dbContext.SaveChangesAsync();
            return StatusCode(201, category);
        }
    }
}
