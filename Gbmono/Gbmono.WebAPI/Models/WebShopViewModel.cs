using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gbmono.WebAPI.Models
{
    public class WebShopViewModel
    {
        public int WebShopId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string LogoUrl { get; set; }
    }
}