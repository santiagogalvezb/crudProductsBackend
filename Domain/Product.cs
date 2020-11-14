using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_api_swagger.Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }

        public Category Category { get; set; }
        public Guid CategoryId { get; set; }
        public Brand Brand { get; set; }
        public Guid BrandId { get; set; }
    }
}
