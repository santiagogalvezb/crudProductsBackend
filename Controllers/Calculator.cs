using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using net_api_swagger.Domain;
using net_api_swagger.Infrastructure;

namespace net_api_swagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Calculator : ControllerBase
    {
        private DjCatalogDbContext _dbContext;
        public Calculator(DjCatalogDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public ContentResult Get()
        {
            var products = _dbContext.Product.Count();
            var brands = _dbContext.Brand.Count();
            var categories = _dbContext.Category.Count();
   


            return Content($"Número de productos: {products} <br>" +
                           $"Número de marcas: {brands} <br>" +
                           $"Numero de categorias: {categories}");
        }

    }
}
