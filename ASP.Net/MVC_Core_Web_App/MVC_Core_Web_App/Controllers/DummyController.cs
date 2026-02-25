using Microsoft.AspNetCore.Mvc;

namespace MVC_Core_Web_App.Controllers
{
    public class DummyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DoDivision(int num1,int num2) 
        {
            try
            {
                float result = num1 / num2;
                ViewBag.Result = result;
            }
            catch (DivideByZeroException ex)
            {
                ViewBag.ErrorMessage = "An error occurred: " + ex.Message;
            } 
            finally
            {
                ViewBag.Num = num1; 
                ViewBag.Num2 = num2;
            }
            return View(); 
        }
    }
}
