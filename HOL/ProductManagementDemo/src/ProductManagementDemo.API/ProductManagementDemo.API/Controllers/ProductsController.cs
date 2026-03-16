using Microsoft.AspNetCore.Mvc;

namespace ProductManagementDemo.API.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
