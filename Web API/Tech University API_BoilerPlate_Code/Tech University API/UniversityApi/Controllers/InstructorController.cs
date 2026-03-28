using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityApi.Interfaces;
using UniversityApi.Models;

namespace UniversityApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorController : ControllerBase
    {
        // Implement your code here
        private readonly IInstructor _repo;
        public InstructorController(IInstructor repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public IActionResult Add(Instructor instructor)
        {
            _repo.AddInstructor(instructor);
            return Ok("Added");
        }
        [HttpGet("course-count")]
        public IActionResult GetByCourseCount(int count)
        {
            var data = _repo.GetInstructorsWithCourseCountAbove(count);
            if(!data.Any()) return NotFound("No Records Found");
            return Ok(data);
        }
        [HttpGet("top")]
        public IActionResult GetTop()
        {
            return Ok(_repo.GetInstructorsWithMostEnrollments());
        }
    }
}
