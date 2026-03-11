using FirstWebAPIDemo.Models.Repos;
using Microsoft.AspNetCore.Mvc;
using FirstWebAPIDemo.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstWebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        StudentRepo srepo = null;
        public StudentController()
        {
            srepo=new StudentRepo();
        }
        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {

            return srepo.GetAll();
            //return new string[] { "value1", "value2" };
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return srepo.Get(id);
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
