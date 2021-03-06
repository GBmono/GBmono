﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Gbmono.Models;
using Gbmono.Models.Infrastructure;
using Gbmono.WebAPI.Services;

namespace Gbmono.WebAPI.Controllers
{
    [RoutePrefix("api/Categories")]
    public class CategoriesController : ApiController
    {
        private readonly CategoryService _categoryService;
        private readonly RepositoryManager _repositoryManager;

        #region ctor
        public CategoriesController()
        {
            _categoryService = new CategoryService();
            _repositoryManager = new RepositoryManager();
        }
        #endregion

        public IEnumerable<Category> GetAll()
        {
            var categories = _repositoryManager.CategoryRepository.Table.ToList();

            // level 1 categories
            var topCategories = categories.Where(m => m.ParentId == null);
            // level 2 categories
            foreach (var topCate in topCategories)
            {
                // level 2
                var subcategories = categories.Where(m => m.ParentId == topCate.CategoryId);

                // attach level 2 categories into top categories
                topCate.SubCategories = subcategories;

                // level 3 categories
                foreach (var subCate in subcategories)
                {
                    // level 3
                    var cates = categories.Where(m => m.ParentId == subCate.CategoryId);

                    // attch
                    subCate.SubCategories = cates;
                }
            }

            return topCategories;
        }

        [Route("FilterCategories/{categoryId}")]
        public async Task<IEnumerable<Category>> GetFilterCategories(int categoryId)
        {
            return await Task.Run(() =>
            {
                return _repositoryManager.CategoryRepository.Fetch(f => f.ParentId == categoryId).ToList();
            });
        }
    }
}
