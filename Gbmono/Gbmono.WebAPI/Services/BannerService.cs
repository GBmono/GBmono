using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Gbmono.Models;
using Gbmono.Models.Infrastructure;

namespace Gbmono.WebAPI.Services
{
    public class BannerService
    {
        private readonly RepositoryManager _repositoryManager;

        public BannerService(RepositoryManager manager)
        {
            _repositoryManager = manager;
        }

        // return banner by product id
        public Banner GetBanner(int productId)
        {
            // todo: temp
            // return the only banner from db
            return _repositoryManager.BannerRepository.Table.FirstOrDefault();            
        }
    }
}