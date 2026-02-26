using ModelsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ModelsDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        //http://localhost:port/home/printemployeeidname?employeeid=1&name=Karthik
        public ActionResult PrintEmployeeIdName(int employeeId, string name)
        {
            return Content(string.Format("EmployeeId = {0} Name= {1}", employeeId, name));
        }


        public ActionResult PrintListNumbers(IList<int> numbers)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var number in numbers)
            {
                sb.AppendFormat("{0}<br/>", number);
            }
            return Content(sb.ToString());
        }

        public ActionResult PrintTrainer([Bind(Exclude = "Subject")]Trainer trainer)
        {
            return Content(string.Format("TrainerId = {0} Name= {1} Designation = {2}", trainer.TrainerId, trainer.TrainerName, trainer.Level.DesignationName));
        }

        public ActionResult AddEmployee()
        {

            return View("AddEmployee", new Employee());
        }

        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {
            
            if (ModelState.IsValid)
            {
                return Content("Form Submitted Successfully");
            }
            return View();
            
        }

        public ActionResult CheckIdExists(int Id)
        {
            if (Id > 100 && Id < 200)
                return Json(false, JsonRequestBehavior.AllowGet);
            else
                return Json(true, JsonRequestBehavior.AllowGet);
        }

    }
}
