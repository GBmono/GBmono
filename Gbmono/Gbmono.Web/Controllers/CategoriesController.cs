using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Gbmono.Models;
using Gbmono.Models.Infrastructure;

namespace Gbmono.Web.Controllers
{
    public class CategoriesController : ApiController
    {
        private readonly RepositoryManager _repositoryManager;

        #region ctor

        public CategoriesController() : this(new RepositoryManager())
        {

        }

        public CategoriesController(RepositoryManager manager)
        {
            _repositoryManager = manager;
        }
        #endregion

        public IEnumerable<Category> GetAll()
        {
            return _repositoryManager.CategoryRepository.Table.ToList();
        }
    }
}
