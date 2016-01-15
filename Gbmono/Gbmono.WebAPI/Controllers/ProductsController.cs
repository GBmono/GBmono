using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Gbmono.Models;
using Gbmono.Models.Infrastructure;
using Gbmono.WebAPI.Services;
using Gbmono.WebAPI.Models;

namespace Gbmono.WebAPI.Controllers
{
    [RoutePrefix("api/Products")]
    public class ProductsController : ApiController
    {
        private readonly ProductService _productService;
        private readonly RepositoryManager _repositoryManager;
        private readonly CategoryService _categoryService;

        public ProductsController() 
        {
            _productService = new ProductService();
            _repositoryManager = new RepositoryManager();
            _categoryService = new CategoryService(_repositoryManager);
        }

        [Route("Categories/{categoryId}")]
        public async Task<IHttpActionResult> GetByCategory(int categoryId)
        {
            var result = await _productService.GetProductByCategory(categoryId);

            return Ok(result);
        }




        [Route("BarCodes/{code}")]
        public Product GetByBarCode(string code)
        {
            return _repositoryManager.ProductRepository
                                     .Table
                                     .SingleOrDefault(m => m.BarCode == code);
        }

        [Route("Recommends")]
        public IEnumerable<Product> GetRecommendedProducts()
        {
            return _repositoryManager.ProductRepository
                                     .Table
                                     .Include(m => m.Brand.Manufacturer) // 读取对应品牌和品牌商
                                     .OrderBy(m => m.ProductCode)
                                     .ToList();
                                     
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            var result = await _productService.GetProductList();
            return Ok(result);
        }

        public async Task<IHttpActionResult> GetById(int id)
        {
            return await Task.Run(() =>
            {
                var product = _repositoryManager.ProductRepository.Fetch(f => f.ProductId == id).FirstOrDefault();
                var model = product.ToViewModel();
                model.Categories = _categoryService.GetProductCategoryList(product.CategoryId);
                return Ok(model);
            });            
        }
    }
}
