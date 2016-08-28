using StartWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StartWebApi.Controllers
{
    public class ProductController : ApiController
    {
        private List<Product> products = new List<Product>()
        {
            new Product {Id = 1, Name = "Shirt M", Price = 30.5M, Qty = 10 },
            new Product {Id = 2, Name = "T Shirt L", Price = 35, Qty = 10 },
            new Product {Id = 3, Name = "Pant XL", Price = 40.6M, Qty = 10 },
            new Product {Id = 4, Name = "Shoes 40", Price = 55, Qty = 10 }
        };
        public IEnumerable<Product> Get()
        {
            return products.ToList();
        }
        public IHttpActionResult Get(int id)
        {
            var product = products.Where(x => x.Id == id);
            if (product == null)
                return NotFound();
            return Ok(product);
        }
    }
}
