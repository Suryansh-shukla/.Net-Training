using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebAppDemo.Controllers
{
    public class DummyController : Controller
    {
        // GET: Dummy
        public ActionResult Index()
        {
            List<string> nameList =new  List<string>{ "Alok", "Riya", "Rajat" };
            ViewBag.Names = nameList;
            return View(nameList);
        }
    }
}