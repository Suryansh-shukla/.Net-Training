using Demo03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo03.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewData["message"] = "Trainer List";

            var trainers = new TrainerService();
            List<Trainer> trainerList = trainers.GetTrainers();

            ViewData["trainers"] = trainerList;
            ViewBag.trainers = trainerList;

            System.Web.HttpContext.Current.Session["TestSession"] = "Data from Session";

            Session["Uname"] = "Ganesh Desai";
            
            return View(trainerList);
        }

        public ActionResult LayoutDemo()
        {
            return View();
        }

    }
}
