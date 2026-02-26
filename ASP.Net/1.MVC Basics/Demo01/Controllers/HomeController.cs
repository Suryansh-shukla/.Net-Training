using Demo01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo01.Controllers
{
    public class HomeController : Controller
    {
       
        /*
          Any public methods(actions) under controller is reachable via URL.
          ActionResult is used to tell the framework what to do next, 
          using ActionResult we can return JSON, XML also 
       */

       
        // GET: /Home/
        // GET: /Home/Index
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Home/AspxView
        public ActionResult AspxView()
        {
            return View();
        }

        // GET: /Home/RazorView
        public ActionResult RazorView()
        {
            return View();
        }

        // GET: /Home/PrintIgate
        public ActionResult PrintIgate()
        {
            return Content("IGATE");
        }

        
        // GET: /Home/PrintId/714709
        // GET: /Home/PrintId?id=714709 (id is a optional Parameter)
        public ContentResult PrintId(string id)
        {
            return Content(string.Format("{0}", id));
        }

        // GET: /Home/PrintName?name=Ganesh
        public ContentResult PrintName(string name)
        {
            return Content(string.Format("Hello {0}", name));
        }

        // GET: /Home/Display (Controller builds and sends Employee Model Display View)
        public ActionResult Display() {
            return View(new Employee { EmployeeId=641716, EmployeeName="Ganesh Desai" });
        }

    }
}
