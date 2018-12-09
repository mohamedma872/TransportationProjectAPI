using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http.Filters;
using TransportationBL.utilities;

namespace TransportationProjectAPI.Filter
{
    public class CustomExceptionFilter: ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {

            var controller = actionExecutedContext.ActionContext.ControllerContext.Controller.ToString();
            var action = actionExecutedContext.ActionContext.ActionDescriptor.ActionName;
            var exception = actionExecutedContext.Exception.Message;
            new Utilities().InsertLog(controller, action, exception);

        }

    }
}