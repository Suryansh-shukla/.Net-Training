using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAdmissionManagement.Models;

namespace StudentAdmissionManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdmissionController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<StudentAdmissionDetailsModel> Get()
        {
            var obj1 = new StudentAdmissionDetailsModel()
            {
                StudentID = 1,
                StudentName = "Adam sandler",
                StudentClass = "X",
                DateofJoining = DateTime.Now
            };
            var obj2 = new StudentAdmissionDetailsModel()
            {
                StudentID = 2,
                StudentName = "Brad Pitt",
                StudentClass = "IX",
                DateofJoining = DateTime.Now
            };
            return new List<StudentAdmissionDetailsModel>() { obj1,obj2 };
        }
    }
}
