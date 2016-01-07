using System;

namespace Gbmono.Models.Models
{
    /// <summary>
    /// 品牌商 (制造商)
    /// </summary>
    public class Manufacturer
    {
        public int ManufacturerId { get; set; }

        public string Name { get; set; }

        public string LogoUrl { get; set; }

        public bool Enabled { get; set; }
    }
}
