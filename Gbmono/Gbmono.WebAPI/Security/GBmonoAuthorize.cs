using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace Gbmono.WebAPI.Security
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public class GbmonoAuthorize : AuthorizeAttribute
    {
        public bool AllowAnonyousUser { get; set; }

        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            var identity = Thread.CurrentPrincipal.Identity;

            if (identity == null && actionContext.RequestContext.Principal != null)
            {
                identity = actionContext.RequestContext.Principal.Identity;
            }

            if (identity != null && identity.IsAuthenticated)
            {
                var basicAuth = identity as ClaimsIdentity;

                if (basicAuth != null)
                {
                    return true;
                }
            }

            if (AllowAnonyousUser)
                return true;

            return false;
        }
    }
}