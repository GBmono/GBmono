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
        public string Category_Name { get; set; }
        public string Product_Image_Url { get; set; }
        public string Description_Image_Url { get; set; }
        public string Instruction_Image_Url { get; set; }
        public double Price { get; set; }

        public ProductViewModel() { }
        public ProductViewModel(Product po)
        {
            if (null == po) return;
            Product_Id = po.ProductId;
            Product_Code = po.ProductCode;
            Brand_Id = po.BrandId;
            Brand_Name = po.Brand.Name;
            Manufacturer_Id = po.Brand.ManufacturerId;
            Manufacturer_Name = po.Brand.Manufacturer.Name;
            Country_Name = po.Country.Name;
            Product_Name = po.PrimaryName;
            Flavor = po.Flavor;
            Content = po.Content;
            Weight_String = string.Format("{0} {1}", po.Weight, po.WeightUnit);
            Shape = po.Shape;
            Texture = po.Texture;
            BarCode = po.BarCode;
            Description = po.Description;
            Instruction = po.Instruction;
            Category_Name = po.Category.Name;
            Price = po.Price;
            // TODO: remove hard code image url
            var r = new Random();
            var num = r.Next(3);
            Product_Image_Url = string.Format("content/images/demo/product_{0}.png", num);
            Instruction_Image_Url = string.Format("content/images/demo/description_{0}.png", num);
        }
    }
}