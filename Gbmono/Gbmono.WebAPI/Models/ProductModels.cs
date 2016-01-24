using System;
using System.Collections.Generic;

namespace Gbmono.WebAPI.Models
{
    /// <summary>
    /// only shows simplified information when return product list result
    /// </summary>
    public class ProductSimpleModel
    {
        public int ProductId { get; set; }

        public string ProductCode { get; set; }

        public string ProductName { get; set; }

        public int BrandId { get; set; }

        public string BrandName { get; set; }

        public double Price { get; set; }

        public string PrimaryImageUrl { get; set; }
    }  


    /// <summary>
    ///  detailed product model
    /// </summary>
    public class ProductDetailModel
    {

    }
}