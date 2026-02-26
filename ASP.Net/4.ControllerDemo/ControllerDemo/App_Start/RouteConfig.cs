using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ControllerDemo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
           routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Custom Routing(Executes based on the order)
           routes.MapRoute(
               name: "iGate", // Route name
               url: "{controller}/{action}/{name}/{age}",
               defaults: new { controller = "Office", action = "Department", name= UrlParameter.Optional, age = UrlParameter.Optional }, // Parameter defaults
               constraints: new  {age = @"^[0-9]+$" } // restricting age only with numbers
               //http://localhost:1396/office/department/anil/35 -  valid
               //http://localhost:1396/office/department/anil/35AA  - Invalid


           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}