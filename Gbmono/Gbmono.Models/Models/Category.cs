using System;

namespace Gbmono.Models.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public int ParentId { get; set; }
    }
}
