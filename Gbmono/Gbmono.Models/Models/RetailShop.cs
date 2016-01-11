using System;
using System.Collections.Generic;

namespace Gbmono.Models
{
    /// <summary>
    /// 零售实体店
    /// </summary>
    public class RetailShop
    {
        public int RetailShopId { get; set; }

        public string Name { get; set; }

        public int CountryId { get; set; }

        public int StateId { get; set; }

        public int SuburbId { get; set; }

        public string Address { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public bool Enabled { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
