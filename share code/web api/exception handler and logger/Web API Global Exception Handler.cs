﻿using System.Text;
using System.Web.Http.ExceptionHandling;
﻿using MI.Dashboard.Models;
﻿using MI.Dashboard.Results;

namespace MI.Dashboard.Infrastracture.ExceptionHandling
{
    /// <summary>
    /// return response message when any unhandled exception occurred
    /// </summary>
    public class GenericTextExceptionHandler: ExceptionHandler
    {
        public override void Handle(ExceptionHandlerContext context)
        {
            context.Result = new InternalServerErrorTextPlainResult(ResultMessage.GenericError, Encoding.UTF8, context.Request);            
        }
    }
}