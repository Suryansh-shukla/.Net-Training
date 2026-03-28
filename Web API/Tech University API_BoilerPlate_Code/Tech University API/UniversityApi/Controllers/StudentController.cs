using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityApi.Interfaces;
using UniversityApi.Models;

namespace UniversityApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // Implement your code here
        private readonly IStudent _repo;
        public StudentController(IStudent repo)
        {
            _repo = repo;
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            var result = _repo.DeleteStudent(id);
            if(!result) return NotFound("No Records Found");
            return Ok("Deleted");

        }
        [HttpGet("by-course")]
        public IActionResult GetByCourse(string title)
        {
            var data = _repo.GetStudentsByCourseTitle(title);
            if(!data.Any()) return NotFound("No Records Found");
            return Ok(data);
        }
    }
    }
