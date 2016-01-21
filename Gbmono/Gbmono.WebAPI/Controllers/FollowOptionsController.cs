using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Gbmono.Models;
using Gbmono.Models.Infrastructure;
using System.Threading.Tasks;
using Gbmono.WebAPI.Security;
using Gbmono.WebAPI.Security.Identities;
using Microsoft.AspNet.Identity;

namespace Gbmono.WebAPI.Controllers
{
    [RoutePrefix("api/FollowOptions")]
    [GbmonoAuthorize]
    public class FollowOptionsController : ApiController
    {
        private readonly RepositoryManager _repositoryManager;
        private readonly IdentityRepositoryManager _identityRepositoryManager;


        #region ctor
        public FollowOptionsController()
        {
            _repositoryManager = new RepositoryManager();
            _identityRepositoryManager = new IdentityRepositoryManager();

        }
        #endregion

        [Route("follow")]
        [HttpPost]
        public async Task<IHttpActionResult> FollowOption(FollowOption option)
        {
            return await Task.Run(() =>
            {
                var id = RequestContext.Principal.Identity;
                var userId = id.GetUserId();
                var userProfile = _identityRepositoryManager.GbmonoUserRepository.Table.Include(m => m.UserProfile).Single(m => m.Id == userId);
                option.UserProfileId = userProfile.UserProfileId;
                //TODO : get user profile id
                var optionPO = _repositoryManager.FollowOptionRepository.Fetch(m => m.FollowTypeId == option.FollowTypeId && m.OptionId == option.OptionId && m.UserProfileId == option.UserProfileId).FirstOrDefault();
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