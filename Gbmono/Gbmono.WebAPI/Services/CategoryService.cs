using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;
using Gbmono.Models;
using Gbmono.WebAPI.Models;
using Gbmono.Models.Infrastructure;

namespace Gbmono.WebAPI.Services
{
    public class CategoryService
    {
        private readonly RepositoryManager _repositoryManager;
        public CategoryService(){}

        public CategoryService(RepositoryManager repo)
        {
            _repositoryManager = repo;
        }


        
    

        public Category GetParentCategory(int id)
        {
            var category = _repositoryManager.CategoryRepository.Get(id);
            return category;           
        }

        public void GetParentCategories(int id, ref List<Category> list)
        {
            var parent = GetParentCategory(id);
            list.Add(parent);
            if (parent.ParentId.HasValue)
            {
                GetParentCategories(parent.ParentId.Value, ref list);
            }
        }

        public List<Category> GetProductCategoryList(int id)
        {
            var list = new List<Category>();
            GetParentCategories(id, ref list);
            list.Reverse();
            return list;
        }

    }
}