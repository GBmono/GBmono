using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Gbmono.WebAPI.Security.Identities;

namespace Gbmono.WebAPI.Controllers
{
    [RoutePrefix("api/Profiles")]
    public class ProfilesController : ApiController
    {

        [Authorize]
        public UserProfile Get()
        {
            var identity = RequestContext.Principal.Identity;
            return null;
        }

    }
}
