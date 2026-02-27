using Microsoft.AspNetCore.Mvc;

namespace MvcCoreWebAppDemo.Controllers
{
    public class CourseController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
