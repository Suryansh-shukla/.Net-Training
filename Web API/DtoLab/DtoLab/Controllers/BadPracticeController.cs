using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DtoLab.Data;
using DtoLab.Models;

namespace DtoLab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BadPracticeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BadPracticeController(AppDbContext context)
        {
            _context = context;
        }

        // 🚨 DANGER: Exposing entity directly!
        [HttpGet("users/{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
                return NotFound();

            // This exposes EVERYTHING - including passwords and SSN!
            return Ok(user);
        }

        // 🚨 DANGER: Returning list of entities
        [HttpGet("users")]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            // All sensitive data exposed!
            return await _context.Users.ToListAsync();
        }
    }
}
