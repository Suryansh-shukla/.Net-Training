using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DtoLab.Data;
using DtoLab.Dtos;

namespace DtoLab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManualMappingController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ManualMappingController(AppDbContext context)
        {
            _context = context;
        }

        // ✅ GOOD: Manual mapping to DTO
        [HttpGet("users/{id}")]
        public async Task<ActionResult<UserDto>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
                return NotFound();

            // Manual mapping - safe and controlled
            var userDto = new UserDto
            {
                Id = user.Id,
                Username = user.Username,
                Email = user.Email,
                Age = CalculateAge(user.DateOfBirth),
                ProfileImageUrl = user.ProfileImageUrl
            };

            return Ok(userDto);
        }

        [HttpGet("users")]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();

            // Manual mapping for collection
            var userDtos = users.Select(u => new UserDto
            {
                Id = u.Id,
                Username = u.Username,
                Email = u.Email,
                Age = CalculateAge(u.DateOfBirth),
                ProfileImageUrl = u.ProfileImageUrl
            }).ToList();

            return Ok(userDtos);
        }

        [HttpGet("admin/users")]
        public async Task<ActionResult<IEnumerable<UserAdminDto>>> GetAdminUsers()
        {
            var users = await _context.Users.ToListAsync();

            // Different DTO for admin view
            var adminDtos = users.Select(u => new UserAdminDto
            {
                Id = u.Id,
                Username = u.Username,
                Email = u.Email,
                IsAdmin = u.IsAdmin,
                CreatedAt = u.CreatedAt,
                DateOfBirth = u.DateOfBirth
            }).ToList();

            return Ok(adminDtos);
        }

        [HttpPost("users")]
        public async Task<ActionResult<UserDto>> CreateUser(CreateUserDto createDto)
        {
            // Map DTO to Entity
            var user = new Models.User
            {
                Username = createDto.Username,
                Email = createDto.Email,
                // In real app, hash the password!
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(createDto.Password),
                DateOfBirth = createDto.DateOfBirth,
                CreatedAt = DateTime.UtcNow
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            // Return DTO, not entity
            var userDto = new UserDto
            {
                Id = user.Id,
                Username = user.Username,
                Email = user.Email,
                Age = CalculateAge(user.DateOfBirth)
            };

            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, userDto);
        }

        private int CalculateAge(DateTime dateOfBirth)
        {
            var today = DateTime.Today;
            var age = today.Year - dateOfBirth.Year;
            if (dateOfBirth.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
}
