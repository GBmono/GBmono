using System;

namespace Gbmono.Models
{
    public class ProductImage
    {
        public int ProductImageId { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public bool IsPrimary { get; set; }

        public bool IsThumbnail { get; set; }

        public string Summary { get; set; }
    }
}
