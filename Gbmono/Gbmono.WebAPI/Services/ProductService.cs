using System;
using System.Collections.Generic;
using System.Data;
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

        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();

        public async Task<List<Product>> GetProductList()
        {
            //Todo to be removed temp here for testing create db
            var repo = new RepositoryManager();
            try
            {
                repo.ProductRepository.Create(new Product() { PrimaryName = "test", ActivationDate = DateTime.Now, CreatedDate = DateTime.Now, ExpiryDate = DateTime.Now, UpdatedDate = DateTime.Now });
                repo.ProductRepository.Save();
            }
            catch (Exception ex)
            {
                var a = ex;
                throw;
            }


            var result = await Task<List<Product>>.Run(() =>
            {
                var productList = new List<Product>();


                var images2 = new List<ProductImage>();
                images2.Add(new ProductImage() { IsPrimary = true, IsThumbnail = false, Name = "merries2_f", Url = "/content/images/demo/merries2_f.jpg" });
                images2.Add(new ProductImage() { IsPrimary = false, IsThumbnail = false, Name = "merries2_b", Url = "/content/images/demo/merries2_b.jpg" });
                var images3 = new List<ProductImage>();
                images3.Add(new ProductImage() { IsPrimary = true, IsThumbnail = false, Name = "merries3_f", Url = "/content/images/demo/merries3_f.jpg" });
                images3.Add(new ProductImage() { IsPrimary = false, IsThumbnail = false, Name = "merries3_b", Url = "/content/images/demo/merries3_b.jpg" });
                var dicImages = new Dictionary<int, List<ProductImage>>();
                dicImages.Add(1, images2);
                dicImages.Add(2, images3);


                for (int i = 0; i < 12; i++)
                {
                    int price = 0, imageIndex = 1;
                    lock (syncLock)
                    { // synchronize
                        price = random.Next(100, 200);
                        imageIndex = random.Next(1, 3);
                    }

                    productList.Add(new Product()
                    {
                        ProductId = i,
                        CategoryId = i,
                        PrimaryName = "纸尿布" + i,
                        BarCode = (4912345678901 + i).ToString(),
                        CuponCode = (8001 + i).ToString(),
                        TopicId = (9001 + i).ToString(),
                        Price = price,
                        Description = "日本本土现货花王拉拉裤9-14",
                        Images = dicImages[imageIndex]
                    });
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