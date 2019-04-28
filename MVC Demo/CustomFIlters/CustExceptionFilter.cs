using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.CustomFIlters
{
    [AttributeUsage(validOn:AttributeTargets.Class | AttributeTargets.Method, AllowMultiple =false)]
    public class CustExceptionFilterAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            string stackTrace = filterContext.Exception.Message + "\n"+ filterContext.Exception.StackTrace;
            //new RedirectToRouteResult("Exception/Index", new System.Web.Routing.RouteValueDictionary());
            filterContext.Result = new ViewResult()
            {
                ViewName = "~Views/Exception/Index"
            };
        }
    }
}