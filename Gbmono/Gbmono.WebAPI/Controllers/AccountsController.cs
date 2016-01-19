using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

using Gbmono.WebAPI.Models;
using Gbmono.WebAPI.Security.Identities;
using Newtonsoft.Json.Linq;

namespace Gbmono.WebAPI.Controllers
{
    [RoutePrefix("api/Accounts")]
    public class AccountsController : ApiController
    {
        private readonly GbmonoUserManager _userManager = null;

        public GbmonoUserManager UserManager
        {
            get { return _userManager ?? Request.GetOwinContext().GetUserManager<GbmonoUserManager>(); }
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("Register")]
        public async Task<IHttpActionResult> Create([FromBody]UserBindingModel model)
        {
            // todo: valiation
            var user = new GbmonoUser() { UserName = model.UserName, Email = model.Email };
            user.UserProfile = new UserProfile();
            user.UserProfile.DisplayName = model.UserName.Split('@')[0];

            IdentityResult result = await UserManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                return GetErrorResult(result);
            }
            var tokenInfo = GetAccessToken(model);
            return Ok(tokenInfo);
            //return Ok(Services.UserExtensions.GetUserProfile(user.UserProfile));
        }


        private AccessTokenViewModel GetAccessToken(UserBindingModel userBinding)
        {
            string URI = null, HtmlResult = null;
            JObject root = new JObject();

            try
            {
                var urlFormat = "http://{0}:{1}/token";

                URI = String.Format(urlFormat, "localhost", 28975);

                var queryDict = new Dictionary<string, string>
                {
                    {"grant_type", "password"},
                    {"username", userBinding.UserName},
                    {"password", userBinding.Password}
                };

                var httpClient = new HttpClient();
                var httpContent = new FormUrlEncodedContent(queryDict);
                var response = httpClient.PostAsync(URI, httpContent).Result;
                HtmlResult = response.Content.ReadAsStringAsync().Result;
                root = JObject.Parse(HtmlResult);

                return new AccessTokenViewModel()
                {
                    Token = root["access_token"].Value<string>(),
                    //UserId = 
                };
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private IHttpActionResult GetErrorResult(IdentityResult result)
        {
            if (result == null)
            {
                return InternalServerError();
            }

            if (!result.Succeeded)
            {
                if (result.Errors != null)
                {
                    foreach (string error in result.Errors)
                    {
                        ModelState.AddModelError("message", error);
                    }
                }

                if (ModelState.IsValid)
                {
                    // No ModelState errors are available to send, so just return an empty BadRequest.
                    return BadRequest();
                }

                return BadRequest(ModelState);
            }

            return null;
        }
    }
}
