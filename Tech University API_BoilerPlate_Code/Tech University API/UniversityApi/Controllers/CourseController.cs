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
        [HttpPut("{courseId}/assign-instructor/{instructorId}")]
        public IActionResult UpdateCourse(Course course)
        {
            // Implement your code here
            return NoContent();
        }
    }
}
