using ControllerDemo.CustomFilters;
using ControllerDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerDemo.Controllers
{
    public class OfficeController : Controller
    {
        //ContentResult
        public ActionResult Department()
        {
            //using RouteData
            return Content(string.Format("Controller : {0} | Action : {1}  |  Name(optional): {2} | Age(Optional) : {3}", RouteData.Values["controller"], RouteData.Values["action"], RouteData.Values["name"], RouteData.Values["age"]));
        }

        /*
        Status 301 means that the resource (page) is moved permanently to a new location. 
        The client/browser should not attempt to request the original location but use the new location from now on.

        Status 302 means that the resource is temporarily located somewhere else, and the client/browser should continue 
        requesting the original url. 
        */

        //Redirect Temporarily HTTP 302
        public ActionResult Action01()
        {
            return Redirect("http://www.igate.com");
        }

        //RedirectPermanent HTTP 301
        public ActionResult Action02()
        {
            return RedirectPermanent("http://www.igate.com");
        }

        //RedirectToAction
        public ActionResult Action03()
        {
            return RedirectToAction("Index", "Home", new { id = "Karthik" });
        }

        //File
        public ActionResult Action04()
        {
            return File(Server.MapPath("~/Content/Site.css"), "text/css", "Test.css");

        }

        //Json
        public ActionResult Action05()
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee { Id = 1, Name = "Ganesh" });
            emplist.Add(new Employee { Id = 2, Name = "Mohan" });
            emplist.Add(new Employee { Id = 3, Name = "Abishek" });
            return Json(emplist, JsonRequestBehavior.AllowGet);
        }

        //HttpUnauthorizedResult - Redirects to login Page
        public ActionResult Action06()
        {
            return new HttpUnauthorizedResult();
        }

        //EmptyResult - specifies doing anything with an action's result
        public ActionResult Action07()
        {
            return new EmptyResult();
        }

        //PartialView 
        public ActionResult Action08()
        {
            return PartialView("pvSample");
        }


        /*Action Selectors*/

        [ActionName("Special")]
        public ActionResult CannotAccessWithThisActionName()
        {
            return Content("Accesible with Special Action Name");
        }

        // [AcceptVerbs(HttpVerbs.Get)]
        [HttpGet]
        // [HttpPost] //Another Easier Way
        public ActionResult AccessViaGet()
        {
            return Content("Accesible only with HTTP GET");
        }



        /*Action Filters - can be applied to Action level or Controller level or Global level(Global.asax.cs - RegisterGlobalFilters)*/


        //Only Authorized Roles, users can access this action, if not authorized Redirects to login Page. 
        [Authorize]
        public ActionResult AuthorizedAction()
        {
            return Content("Accesible only to Authorized users");
        }

        //CustomError mode needs to be on in web.config under system.web section to 
        //show the Error view(Error.cshtml) available under shared folder

        [HandleError] // Handles error this Action. It is already registered in Global.asax(FilterConfig under App_Start)
        public ActionResult ErrorMethod()
        {
            throw new Exception("Not Implemented");
        }

        [IgateFilter] //Custom filter - /office/customfilter/igate redirects to Home Controller About Action
        public ActionResult CustomFilter(string name)
        {
            return Content(string.Format("Name Given : {0}", name));
        }

    }
}
