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
    public class CommodityController : ApiController
    {
        private readonly RepositoryManager<Commodity> _repositoryManager;

        #region ctor

        public CommodityController() : this(new RepositoryManager<Commodity>())
        {

        }

        public CommodityController(RepositoryManager<Commodity> manager)
        {
            _repositoryManager = manager;
        }
        #endregion

        public IEnumerable<Commodity> GetCommodityListByConditions()
        {
            //Todo Search By Condition
            return _repositoryManager.Repository.Table.ToList();
        }


        public Commodity GetCommodityDetail(int id)
        {
            return _repositoryManager.Repository.Get(id);
        }

    }
}
