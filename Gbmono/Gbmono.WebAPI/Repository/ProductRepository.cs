using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Gbmono.Models;

namespace Gbmono.WebAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();

        public async Task<List<Product>> GetProductList()
        {

            var result = await Task<List<Product>>.Run(() =>
            {
                var productList = new List<Product>();

                var images1 = new List<ProductImage>();
                images1.Add(new ProductImage() { IsPrimary = true, IsThumbnail = false, Name = "merries1_f", Url = "/pics/merries1_f.jpg" });
                images1.Add(new ProductImage() { IsPrimary = false, IsThumbnail = false, Name = "merries1_b", Url = "/pics/merries1_b.jpg" });
                var images2 = new List<ProductImage>();
                images2.Add(new ProductImage() { IsPrimary = true, IsThumbnail = false, Name = "merries2_f", Url = "/pics/merries2_f.jpg" });
                images2.Add(new ProductImage() { IsPrimary = false, IsThumbnail = false, Name = "merries2_b", Url = "/pics/merries2_b.jpg" });
                var images3 = new List<ProductImage>();
                images3.Add(new ProductImage() { IsPrimary = true, IsThumbnail = false, Name = "merries3_f", Url = "/pics/merries3_f.jpg" });
                images3.Add(new ProductImage() { IsPrimary = false, IsThumbnail = false, Name = "merries3_b", Url = "/pics/merries3_b.jpg" });
                var dicImages = new Dictionary<int, List<ProductImage>>();
                dicImages.Add(1, images1);
                dicImages.Add(2, images2);
                dicImages.Add(3, images3);


                for (int i = 0; i < 12; i++)
                {
                    int price = 0, imageIndex = 1;
                    lock (syncLock)
                    { // synchronize
                        price = random.Next(100, 200);
                        imageIndex = random.Next(1,4);
                    }

                    productList.Add(new Product()
                    {
                        CategoryId = i,
                        PrimaryName = "纸尿布" + i,
                        BarCode = (4912345678901 + i).ToString(),
                        CuponCode = (8001 + i).ToString(),
                        TopicId = 9001 + i,
                        Price = price,
                        Description = "日本本土现货花王拉拉裤9-14",
                        Images = dicImages[imageIndex]
                    });
                }
                return productList;
            });


            return result;
        }
    }
}