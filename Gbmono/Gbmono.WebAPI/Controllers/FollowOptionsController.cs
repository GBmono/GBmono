﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Gbmono.Models;
using Gbmono.Models.Infrastructure;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Gbmono.WebAPI.Security;
using Gbmono.WebAPI.Security.Identities;
using Gbmono.WebAPI.Attributes;

namespace Gbmono.WebAPI.Controllers
{
    [RoutePrefix("api/FollowOptions")]
    [Authorize]
    public class FollowOptionsController : ApiController
    {
        private readonly RepositoryManager _repositoryManager;


        #region ctor
        public FollowOptionsController()
        {
            _repositoryManager = new RepositoryManager();

        }
        #endregion

        [Route("follow")]
        [HttpPost]
        [Authorize]
        public async Task<IHttpActionResult> FollowOption(FollowOption option)
        {
            return await Task.Run(() =>
            {
                var userId = RequestContext.Principal.Identity.GetUserId();
                option.UserId = userId;
                var optionPO = _repositoryManager.FollowOptionRepository.Get(m => m.FollowTypeId == option.FollowTypeId && m.OptionId == option.OptionId && m.UserId == option.UserId);
                if (optionPO == null)
                {
                    option.CreatedDate = DateTime.Now;
                    _repositoryManager.FollowOptionRepository.Create(option);
                }
                else
                {
                    _repositoryManager.FollowOptionRepository.Delete(optionPO);
                }
                _repositoryManager.FollowOptionRepository.Save();
                return Ok();
            });
        }
    }
}