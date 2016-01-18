using Gbmono.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gbmono.WebAPI.Models
{
    public class ProductViewModel
    {
        public int Product_Id { get; set; }
        public string Product_Code { get; set; }
        public int Brand_Id { get; set; }
        public string Brand_Name { get; set; }
        public int Manufacturer_Id { get; set; }
        public string Manufacturer_Name { get; set; }
        public string Country_Name { get; set; }
        public string Product_Name { get; set; }
        public string Flavor { get; set; }
        public string Content { get; set; }
        public string Weight_String { get; set; }
        public string Shape { get; set; }
        public string Texture { get; set; }
        public string BarCode { get; set; }
        public string Description { get; set; }
        public string Instruction { get; set; }        
        public string Product_Image_Url { get; set; }
        public string Description_Image_Url { get; set; }
        public string Instruction_Image_Url { get; set; }
        public double Price { get; set; }

        public List<Category> Categories { get; set; }
        public List<Retailer> Retailers { get; set; }
        public List<WebShop> WebShops { get; set; }
        public ProductViewModel() { }        
    }
}