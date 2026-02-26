using Demo02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo02.Controllers
{
    public class GuestController : Controller
    {
        //
        // GET: /Guest/

        public ActionResult Index()
        {
            var guestDetails = new GuestService();
            var guests = guestDetails.GetAllGuests();
            return View(guests);
        }

        //
        // GET: /Guest/Details/5

        public ActionResult Details(int id)
        {
            GuestService gs = new GuestService();
            Guest guest = gs.ShowGuest(id);
            return View(guest);
        }

        //
        // GET: /Guest/Create

        public ActionResult Create()
        {
            return View(new Guest());
        }

        //
        // POST: /Guest/Create

        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    Guest newGuest = null;
        //    try
        //    {
        //        newGuest = new Guest();
        //        newGuest.GuestNo = Int32.Parse(collection["GuestNo"]);
        //        newGuest.GuestName = collection["GuestName"];
        //        newGuest.PhoneNumber = collection["PhoneNumber"];

        //        GuestService gs = new GuestService();
        //        gs.AddGuest(newGuest);
        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View(newGuest);
        //    }
        //}


         [HttpPost]
         public ActionResult Create(Guest newGuest)
         {
             if (ModelState.IsValid)
             {
                 GuestService gs = new GuestService();
                 gs.AddGuest(newGuest);

                 return RedirectToAction("Index");
             }
             else
             {
                 return View(newGuest);
             }
         }

        //
        // GET: /Guest/Edit/5

        public ActionResult Edit(int id)
        {
            GuestService gs = new GuestService();
            Guest guest = gs.ShowGuest(id);
            return View(guest);
        }

        //
        // POST: /Guest/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            Guest updateGuest = null;
            try
            {
                updateGuest = new Guest();
                updateGuest.GuestNo = id;
                updateGuest.GuestName = collection["GuestName"];
                updateGuest.PhoneNumber = collection["PhoneNumber"];
                GuestService gs = new GuestService();
                gs.UpdateGuest(updateGuest);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(updateGuest);
            }
        }


        /*
        // POST: /Guest/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Guest guest)
        {
            if (ModelState.IsValid)
            {
                GuestService gs = new GuestService();
                gs.UpdateGuest(guest);
                return RedirectToAction("Index");
            }
            else
            {
                return View(guest);
            }
        }*/

        //
        // GET: /Guest/Delete/5

        public ActionResult Delete(int id)
        {
            GuestService gs = new GuestService();
            Guest guest = gs.ShowGuest(id);
            return View(guest);
        }

        //
        // POST: /Guest/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            Guest deleteGuest = null;
            try
            {
                deleteGuest = new Guest();
                deleteGuest.GuestName = collection["GuestName"];
                deleteGuest.PhoneNumber = collection["PhoneNumber"];
                GuestService gs = new GuestService();
                gs.RemoveGuest(id);             
                return RedirectToAction("Index");
            }
            catch
            {
                return View(deleteGuest);
            }
        }
    }
}
