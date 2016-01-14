﻿using System;
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

namespace Gbmono.WebAPI.Controllers
{
    [RoutePrefix("Products")]
    public class ProductsController : ApiController
    {
        private readonly ProductService _productService;
        private readonly RepositoryManager _repositoryManager;

        public ProductsController() 
        {
            _productService=new ProductService();
            _repositoryManager = new RepositoryManager();
        }

        [Route("Categories/{categoryId}")]
        public IEnumerable<Product> GetByCategory(int categoryId)
        {
            return _repositoryManager.ProductRepository
                                     .Fetch(m => m.CategoryId == categoryId)
                                     .OrderBy(m => m.PrimaryName)
                                     .ToList();
        }

        public Product GetById(int id)
        {
            return _repositoryManager.ProductRepository.Get(id);
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

        [Route("GetProductList")]
        [HttpGet]
        public async Task<IHttpActionResult> GetProductList()
        {

            var result =await _productService.GetProductList();

            return Ok(result);
        }


        [Route("GetProduct/{id}")]
        [HttpGet]
        public async Task<IHttpActionResult> GetProduct(int id)
        {
            return await Task.Run(() =>
            {
                return Ok(_repositoryManager.ProductRepository.Fetch(f => f.ProductId == id));
            });            
        }

    }
}
