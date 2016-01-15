using Gbmono.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gbmono.WebAPI.Models
{
    public class CategoryViewModel
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string CategoryCode { get; set; }
        public int? ParentId { get; set; }
        public CategoryViewModel() { }
    }
}