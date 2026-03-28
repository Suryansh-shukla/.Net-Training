using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityApi.Interfaces;
using UniversityApi.Models;

namespace UniversityApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        // Implement your code here
        private readonly ICourse _repo;
        public CourseController(ICourse repo)
        {
            _repo = repo;
        }
        [HttpPut]
        public IActionResult Update(Course course)
        {
            var result = _repo.UpdateCourse(course);
            if(!result) return NotFound("No Records Found");
            return Ok("Updated");
        }
         [HttpGet("grade")]
         public IActionResult GetByGrade(int grade)
        {
            var data = _repo.GetCoursesWithEnrollmentsAboveGrade(grade);
            if(!data.Any()) return NotFound("No Records Found");
            return Ok(data);
        }
        [HttpGet("instructor")]
        public IActionResult GetByInstructor(string name)
        {
            var data = _repo.GetCoursesByInstructorName(name);
            if(!data.Any()) return NotFound("No Records Found");
            return Ok(data);
        }
    }
}
