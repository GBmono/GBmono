﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Cors;
using Gbmono.Models.DataContext;
using Gbmono.WebAPI.ExceptionHandling;
using Microsoft.SqlServer.Server;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace Gbmono.WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            log4net.Config.XmlConfigurator.Configure();
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
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // using camel casing for property names
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            // ignore reference loop handling
            config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;

            // remove default XML hanlder
            var matches = config.Formatters
                               .Where(f => f.SupportedMediaTypes.Where(
                                m => m.MediaType.ToString() == "application/xml" || m.MediaType.ToString() == "text/xml").Count() > 0)
                               .ToList();

            foreach (var match in matches)
            {
                config.Formatters.Remove(match);    // remove
            }

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<GbmonoSqlContext, Gbmono.Models.Migrations.Configuration>());
        }
    }
}
