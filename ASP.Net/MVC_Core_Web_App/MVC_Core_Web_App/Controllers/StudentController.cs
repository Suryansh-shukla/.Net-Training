using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Core_Web_App.Models;

namespace MVC_Core_Web_App.Controllers
{
    public class StudentController : Controller
    {
        StudentRepo srepo = null ;
        public StudentController()
        {
            srepo=new StudentRepo();
        }
        [HttpGet]
        public string[] GetAllcities()
        {
            return new string[] { "Pune", "Mumbai", "Delhi", "Bangalore","Chennai","Hyderabase" };
        }
        // GET: StudentController
        public ActionResult Index()
        {
            List<Student> sList=srepo.ShowAllData();
            return View(sList);
        }

        // GET: StudentController/Details/5
        
        public ActionResult Details(int id)
        {
            Student s=srepo.ShowDetailsByID(id);
            return View(s);
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student s1)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    srepo.AddData(s1);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Student collection)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    srepo.UpdateData(id, collection);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Student collection)
        {
            try
            {
                if(ModelState.IsValid)
                { 
                    srepo.DeleteData(id);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
