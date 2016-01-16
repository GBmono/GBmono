using Gbmono.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gbmono.WebAPI.Models
{
    public static class ModelExtensions
    {
        public static CategoryViewModel ToViewModel(this Category po)
        {
            var model = new CategoryViewModel();
            model.CategoryId = po.CategoryId;
            model.Name = po.Name;
            model.CategoryCode = po.CategoryCode;
            model.ParentId = po.ParentId;
            return model;
        }

        public static ProductViewModel ToViewModel(this Product po)
        {
            if (null == po) return null;
            var model = new ProductViewModel();
            model.Product_Id = po.ProductId;
            model.Product_Code = po.ProductCode;
            model.Brand_Id = po.BrandId;
            model.Brand_Name = po.Brand.Name;
            model.Manufacturer_Id = po.Brand.ManufacturerId;
            model.Manufacturer_Name = po.Brand.Manufacturer.Name;
            model.Country_Name = po.Country.Name;
            model.Product_Name = po.PrimaryName;
            model.Flavor = po.Flavor;
            model.Content = po.Content;
            model.Weight_String = string.Format("{0} {1}", po.Weight, po.WeightUnit);
            model.Shape = po.Shape;
            model.Texture = po.Texture;
            model.BarCode = po.BarCode;
            model.Description = po.Description;
            model.Instruction = po.Instruction;
            model.Price = po.Price;
            model.Retailers = new List<RetailerViewModel>();
            foreach (var retailer in po.Retailers)
            {
                model.Retailers.Add(retailer.ToViewModel());
            }
            model.WebShops = po.WebShops.Select(m => m.ToViewModel()).ToList();
            // TODO: remove hard code image url
            var r = new Random();
            var num = r.Next(3);
            model.Product_Image_Url = string.Format("content/images/demo/product_{0}.png", num);
            model.Instruction_Image_Url = string.Format("content/images/demo/description_{0}.png", num);
            return model;
        }

        public static RetailerViewModel ToViewModel(this Retailer po)
        {
            var model = new RetailerViewModel();
            model.RetailerId = po.RetailerId;
            model.Name = po.Name;
            model.LogoUrl = po.LogoUrl;
            return model;
        }

        public static WebShopViewModel ToViewModel(this WebShop po)
        {
            var model = new WebShopViewModel();
            model.WebShopId = po.WebShopId;
            model.Name = po.Name;
            model.Url = po.Url;
            model.LogoUrl = po.LogoUrl;
            return model;
        }
    }
}