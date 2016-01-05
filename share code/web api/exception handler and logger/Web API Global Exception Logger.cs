using System;
using System.Net.Http;
using System.Web;
﻿using System.Web.Http.ExceptionHandling;

using NLog;

namespace MI.Core.WebApi.ExceptionHandling
{
    /// <summary>
    /// exception logger, use NLog module to log unexpected error information
    /// </summary>
    public class NLogExceptionLogger : ExceptionLogger
    {
        private const string HttpContextBaseKey = "MS_HttpContext";

        // override the defualt log method, call NLog model to log exception 
        public override void Log(ExceptionLoggerContext context)
        {
            // Retrieve the current HttpContext instance for this request.
            HttpContext httpContext = GetHttpContext(context.Request);

            if (httpContext == null)
            {
                return;
            }
            
            // Send the exception to NLog (for logging, mailing, filtering, etc.).
            var logger = LogManager.GetCurrentClassLogger();

            // get the base exception to show the useful exception information
            var baseException = context.Exception.GetBaseException();

            // log
            logger.Log(LogLevel.Error, baseException.Message + "\n\r" + baseException.StackTrace);
           
        }

        private static HttpContext GetHttpContext(HttpRequestMessage request)
        {
            HttpContextBase contextBase = GetHttpContextBase(request); // get the HttpContextBase instance from request

            if (contextBase == null)
            {
                return null;
            }

            // get the HttpContext of the HttpContextBase
            return ToHttpContext(contextBase);
        }

        private static HttpContextBase GetHttpContextBase(HttpRequestMessage request)
        {
            if (request == null)
            {
                return null;
            }

            object value;

            if (!request.Properties.TryGetValue(HttpContextBaseKey, out value))
            {
                return null;
            }

            return value as HttpContextBase;
        }

        private static HttpContext ToHttpContext(HttpContextBase contextBase)
        {
            return contextBase.ApplicationInstance.Context;
        }
    }
}
