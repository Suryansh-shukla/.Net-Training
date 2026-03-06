using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentPortal.Models;
using StudentPortal.Services;

namespace StudentPortal.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService _service;

        public StudentsController(IStudentService service)
        {
            _service = service;
        }

        private void LoadStatusDropdown()
        {
            ViewBag.StatusList = new List<string>
            {
                "Active",
                "Inactive",
                "Suspended"
            };
        }

        public async Task<IActionResult> Index(string searchName, string status)
        {
            var students = await _service.GetAllAsync();

            if (!string.IsNullOrWhiteSpace(searchName))
            {
                students = students
                    .Where(s => s.FullName != null &&
                                s.FullName.ToLower().Contains(searchName.ToLower()))
                    .ToList();
            }

            if (!string.IsNullOrWhiteSpace(status))
            {
                students = students
                    .Where(s => s.Status == status)
                    .ToList();
            }

            LoadStatusDropdown();

            return View(students);
        }

        public async Task<IActionResult> Create()
        {
            LoadStatusDropdown();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Student student)
        {
            if (ModelState.IsValid)
            {
                student.CreatedAt = DateTime.Now;
                await _service.AddAsync(student);
                return RedirectToAction(nameof(Index));
            }

            LoadStatusDropdown();
            return View(student);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var student = await _service.GetByIdAsync(id.Value);
            if (student == null) return NotFound();

            LoadStatusDropdown();
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Student student)
        {
            if (id != student.StudentId)
                return NotFound();

            if (ModelState.IsValid)
            {
                await _service.UpdateAsync(student);
                return RedirectToAction(nameof(Index));
            }

            LoadStatusDropdown();
            return View(student);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var student = await _service.GetByIdAsync(id.Value);
            if (student == null) return NotFound();

            return View(student);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}