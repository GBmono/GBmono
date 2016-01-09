using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Gbmono.Models;

namespace Gbmono.WebAPI.Repository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProductList();

        Task<Product> GetProductById(int productId);
    }
}
