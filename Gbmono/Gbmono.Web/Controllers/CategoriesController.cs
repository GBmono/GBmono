using Gbmono.Models;
using Gbmono.Models.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Gbmono.Web.Controllers
{
    public class CategoriesController : ApiController
    {
        private readonly RepositoryManager<Category> _repositoryManager;

        #region ctor

        public CategoriesController() : this(new RepositoryManager<Category>())
        {

        }

        public CategoriesController(RepositoryManager<Category> manager)
        {
            _repositoryManager = manager;
        }
        #endregion

        public IEnumerable<Category> GetAll()
        {
            return _repositoryManager.Repository.Table.ToList();
        }
    }
}
