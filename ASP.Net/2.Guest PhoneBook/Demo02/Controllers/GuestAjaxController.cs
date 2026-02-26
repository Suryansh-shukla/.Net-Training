using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo02.Models;

namespace Demo02.Controllers
{
    public class GuestAjaxController : Controller
    {
        //
        // GET: /GuestAjax/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Guest guest)
        {
            GuestService gs = new GuestService();
            Guest guestObj = gs.ShowGuest(guest.GuestNo);
            return View(guestObj);
           
        }
    }
}
