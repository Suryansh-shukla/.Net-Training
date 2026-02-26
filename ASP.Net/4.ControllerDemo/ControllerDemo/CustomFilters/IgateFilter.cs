using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ControllerDemo.CustomFilters
{
    /*Custom Filter*/
    public class IgateFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            if (filterContext.RouteData.Values["name"] != null)
            {
                if (filterContext.RouteData.Values["name"].ToString().ToLower().Equals("igate"))
                {
                    filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Home", action = "About" }));
                }
            }
        }


    }
}