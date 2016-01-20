using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Gbmono.WebAPI.Security.Identities;
using Microsoft.AspNet.Identity;

namespace Gbmono.WebAPI.Controllers
{
    [RoutePrefix("api/Profiles")]
    public class ProfilesController : ApiController
    {
        private readonly IdentityRepositoryManager _repositoryManager;

        public ProfilesController()
        {
            _repositoryManager = new IdentityRepositoryManager();
        }

        [Authorize]
        public UserProfile Get()
        {
            var identity = RequestContext.Principal.Identity;
            var userId = identity.GetUserId();

            var userProfile = _repositoryManager.GbmonoUserRepository.Table.Include(m => m.UserProfile).Single(m => m.Id == userId);


            return null;
        }

    }
}
