using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Gbmono.Models;
using Gbmono.Models.Infrastructure;
using Gbmono.WebAPI.Repository;

namespace Gbmono.WebAPI.Controllers
{
    public class ProductController : ApiController
    {
        private readonly ProductService _productService;

        public ProductController() 
        {
            _productService=new ProductService();
        }




        [HttpGet]
        public async Task<IHttpActionResult> GetProductList()
        {
            var result =await _productService.GetProductList();

            return Ok(result);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetProduct(int id)
        {
            return Ok(await _productService.GetProductById(id));
        }

    }
}
