using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Gbmono.Models;
using Gbmono.Models.Infrastructure;
using Gbmono.WebAPI.Services;

namespace Gbmono.WebAPI.Controllers
{
    [RoutePrefix("api/Banners")]
    public class BannersController : ApiController
    {
        private readonly RepositoryManager _repositoryManager;
        private readonly BannerService _bannerService;

        #region ctor
        public BannersController()
        {
            _repositoryManager = new RepositoryManager();
            _bannerService = new BannerService(_repositoryManager);

        }
        #endregion

        [Route("Products/{productId}")]
        public Banner GetBanner(int productId)
        {
            return _bannerService.GetBanner(productId);
        }
    }
}
