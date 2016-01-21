using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Gbmono.WebAPI.Models;
using Gbmono.WebAPI.Security.Identities;
using Gbmono.WebAPI.Services;
using Microsoft.AspNet.Identity;

namespace Gbmono.WebAPI.Controllers
{
    [RoutePrefix("api/Profiles")]
    public class ProfilesController : ApiController
    {
        private readonly IdentityRepositoryManager _identityRepositoryManager;


        public ProfilesController()
        {
            _identityRepositoryManager = new IdentityRepositoryManager();
        }

        [Authorize]
        public UserProfileViewModel Get()
        {
            var identity = RequestContext.Principal.Identity;
            var userId = identity.GetUserId();

            var userProfile = _identityRepositoryManager.GbmonoUserRepository.Table.Include(m => m.UserProfile).Single(m => m.Id == userId);
            var result = UserExtensions.GetUserProfile(userProfile.UserProfile);

            return result;
        }

    }
}
