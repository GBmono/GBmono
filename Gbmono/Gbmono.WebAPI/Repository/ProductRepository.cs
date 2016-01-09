using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Gbmono.Models;

namespace Gbmono.WebAPI.Repository
{
    public class ProductRepository: IProductRepository
    {
        public async Task<List<Product>> GetProductList()
        {
            var result = await Task<List<Product>>.Run(() =>
            {
                var productList = new List<Product>();
                for (int i = 0; i < 10; i++)
                {
                    productList.Add(new Product()
                    {
                        CategoryId = i,
                        PrimaryName = "纸尿布" + i,
                        BarCode = (4912345678901 + i).ToString(),
                        CuponCode = (8001 + i).ToString(),
                        TopicId = 9001 + i
                    });
                }
                return productList;
            });

           
            return result;
        }
    }
}