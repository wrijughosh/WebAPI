using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPCoreWebAPIAAD.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreWebAPIAAD.Controllers
{
    [Route("api/products")]
    public class ProductsController : Controller
    {
        [HttpGet]
        public Product[] Get()
        {
            return Repository.Products.ToArray();
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return Repository.GetProductById(id);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Product product)
        {
            Repository.ReplaceProductById(id, product);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Repository.RemoveProductById(id);
        }

        [HttpPost]
        public void Post([FromBody]Product product)
        {
            Repository.AddProduct(product);
        }
    }
}