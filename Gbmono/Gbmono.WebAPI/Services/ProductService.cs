using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using Gbmono.Models;
using Gbmono.Models.Infrastructure;

namespace Gbmono.WebAPI.Services
{
    public class ProductService
    {
        private readonly RepositoryManager _repositoryManager;

        public ProductService(RepositoryManager manager)
        {
            _repositoryManager = manager;
        }

        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();

        public async Task<List<Product>> GetProductList()
        {
            var result = await Task<List<Product>>.Run(() =>
            {
                var productList = _repositoryManager.ProductRepository
                                                    .Table
                                                    .Include(m => m.Retailers)
                                                    .ToList();

                foreach (var product in productList)
                {
                    //Todo Temp
                    if (product.Images == null)
                    {
                        product.Images = new List<ProductImage>();
                        product.Images.Add(new ProductImage() { IsPrimary = true, IsThumbnail = false, Name = "PicTemp", Url = "/content/images/demo/merries2_f.jpg" });
                        product.Images.Add(new ProductImage()
                        {
                            IsPrimary = false,
                            IsThumbnail = false,
                            Name = "PicTemp2",
                            Url = "/content/images/demo/merries2_b.jpg"
                        });
                    }
                }

                return productList;
            });


            return result;
        }

        public async Task<List<Product>> GetProductByCategory(int categoryId)
        {
            var result = await Task<List<Product>>.Run(() =>
            {
                var productList = _repositoryManager.ProductRepository
                                    .Fetch(m => m.CategoryId == categoryId)
                                    .OrderBy(m => m.PrimaryName)
                                    .ToList();

                foreach (var product in productList)
                {
                    if (product.Images == null)
                    {
                        product.Images = new List<ProductImage>();
                        product.Images.Add(new ProductImage() { IsPrimary = true, IsThumbnail = false, Name = "PicTemp", Url = "/content/images/demo/merries2_f.jpg" });
                        product.Images.Add(new ProductImage()
                        {
                            IsPrimary = false,
                            IsThumbnail = false,
                            Name = "PicTemp2",
                            Url = "/content/images/demo/merries2_b.jpg"
                        });
                    }

                    //Todo  Fetch  Include table
                    if (product.Retailers == null)
                    {
                        product.Retailers = new List<Retailer>();
                        product.Retailers.Add(new Retailer() { RetailerId = 3, Name = "松本清" });
                        product.Retailers.Add(new Retailer() { RetailerId = 4, Name = "资深堂" });
                    }
                }


                return productList;
            });


            return result;
        }


        public async Task<Product> GetProductById(int productId)
        {
            return await Task.Run(() =>
            {
                return new Product
                {
                    ProductId = productId,
                    PrimaryName = "moony air fit 搭扣M64片",
                    Brand = new Brand() { BrandId = 1, Name = "尤妮佳" },
                    Content = "64",
                    // ContentUnit = "片",
                    Images = new List<ProductImage>() { new ProductImage { IsPrimary = true, Url = "content/images/demo/moony3.jpg", Name = "test1" } },
                    Price = 1784,
                    //RetailShops = new List<RetailShop>() { new RetailShop { Name = "松本清(Matsumotokiyoshi)" }, new RetailShop { Name = "Tsuruha(ツルハ)" }, new RetailShop { Name = "Sundurg（サンドラッグ）" }, new RetailShop { Name = "Sugi（スギ）" }, new RetailShop { Name = "札幌药妆（サッポロドラッグストア）" } },
                    WebShops = new List<WebShop>() { new WebShop { Name = "A店" } }
                };
            });
        }
    }
}