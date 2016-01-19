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

namespace Gbmono.WebAPI.Controllers
{
    [RoutePrefix("api/FollowOptions")]
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
        public async Task<IHttpActionResult> FollowOption(FollowOption option)
        {
            return await Task.Run(() =>
            {
                if (!_repositoryManager.FollowOptionRepository.Any(m => m.FollowTypeId == option.FollowTypeId && m.OptionId == option.OptionId && m.UserProfileId == option.UserProfileId))
                {
                    _repositoryManager.FollowOptionRepository.Create(option);
                }
                else
                {
                    _repositoryManager.FollowOptionRepository.Delete(option);
                }
                _repositoryManager.FollowOptionRepository.Save();
                return Ok();
            });
        }
    }
}