﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Gbmono.Models;
using Gbmono.Models.Infrastructure;

namespace Gbmono.WebAPI.Controllers
{
    [RoutePrefix("api/Countries")]
    public class CountriesController : ApiController
    {
        private readonly RepositoryManager _repositoryManager;

        #region ctor
        public CountriesController()
        {
            _repositoryManager = new RepositoryManager();
        }
        #endregion
    }
}
