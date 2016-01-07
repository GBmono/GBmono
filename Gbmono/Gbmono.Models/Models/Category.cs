using System;

namespace Gbmono.Models
{ 
    public class Category
    {
        public int Id { get; set; }

        public string CategoryId { get; set; }

        public string Name { get; set; }

        public int ParentId { get; set; }
    }
}
