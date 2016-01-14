using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Cors;
using Gbmono.WebAPI.ExceptionHandling;

namespace Gbmono.WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));

            // Web API configuration and services
            // Global error handling
            // exception logger
            // There can be multiple exception loggers. (By default, no exception loggers are registered.)
            // we register exception logger here
            // config.Services.Add(typeof(IExceptionLogger), new GenericExceptionLogger());

            // There must be exactly one exception handler. (There is a default one that may be replaced.)
            // To make this sample easier to run in a browser, replace the default exception handler with one that sends
            // back text/plain content for all errors.
            // config.Services.Replace(typeof(IExceptionHandler), new GenericExceptionHandler());

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
