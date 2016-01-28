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
        private readonly RepositoryManager _repositoryManager;
        private readonly CategoryService _categoryService;
        private readonly BannerService _bannerService;

        public ProductsController() 
        {
            _repositoryManager = new RepositoryManager();
            _categoryService = new CategoryService(_repositoryManager);
            _bannerService = new BannerService(_repositoryManager);
        }
        
        // get product by id
        public async Task<ProductDetailModel> GetById(int id)
        {
            return await Task.Run(() =>
            {
                var product = _repositoryManager.ProductRepository.Table
                                                                  .Include(m => m.Country)
                                                                  .Include(m => m.Brand.Manufacturer)
                                                                  .Include(m => m.Retailers)
                                                                  .Include(m => m.WebShops)
                                                                  .SingleOrDefault(f => f.ProductId == id);
                if (product != null)
                {
                    var model = product.ToModel();
                    model.Categories = _categoryService.GetProductCategoryList(product.CategoryId);
                    return model;
                }

                return null;
            });
        }

        public async Task<IEnumerable<ProductSimpleModel>> GetAll()
        {
            return await Task.Run(() =>
            {
                var productList = _repositoryManager.ProductRepository.Table
                                                                .Include(m => m.Brand)
                                                                .Include(m => m.Retailers)
                                                                .Take(20).ToList();
                if (productList != null && productList.Count > 0)
                {
                    var models = productList.Select(m => m.ToSimpleModel()).ToList();
                    return models;
                }
                return null;
            });
        }

        [Route("Categories/{categoryId}")]
        public async Task<IEnumerable<ProductSimpleModel>> GetByCategory(int categoryId)
        {
            return await Task.Run(() =>
            {
                var productList = _repositoryManager.ProductRepository.Table
                                    .Include(m => m.Brand)
                                    .Include(m => m.Retailers)
                                    .Where(m => m.CategoryId == categoryId)
                                    .OrderBy(m => m.PrimaryName)
                                    .Take(20)
                                    .ToList();
                if (productList != null && productList.Count > 0)
                {
                    var models = productList.Select(m => m.ToSimpleModel()).ToList();
                    return models;
                }
                return null;

            });
        }

        // get banner by product id
        [Route("{id}/Banner")]
        public Banner GetBanner(int id)
        {
            return _bannerService.GetBanner(id);
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

    }
}
