using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Student_Management_System.Data;

namespace Student_Management_System.Controllers
{
    public class StudentDashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentDashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Profile(int id)
        {
            var student = _context.Students
                .Include(x => x.Course)
                .Include(x => x.Department)
                .FirstOrDefault(x => x.StudentId == id);

            return View(student);
        }
    }
}
