using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using DtoLab.Data;
using DtoLab.Dtos;
using DtoLab.Models;

namespace DtoLab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoMapperController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public AutoMapperController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("users/{id}")]
        public async Task<ActionResult<UserDto>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
                return NotFound();

            var userDto = _mapper.Map<UserDto>(user);
            return Ok(userDto);
        }

        [HttpGet("users")]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            var userDtos = _mapper.Map<List<UserDto>>(users);
            return Ok(userDtos);
        }

        [HttpGet("admin/users")]
        public async Task<ActionResult<IEnumerable<UserAdminDto>>> GetAdminUsers()
        {
            var users = await _context.Users.ToListAsync();
            var adminDtos = _mapper.Map<List<UserAdminDto>>(users);
            return Ok(adminDtos);
        }

        [HttpPost("users")]
        public async Task<ActionResult<UserDto>> CreateUser(CreateUserDto createDto)
        {
            var user = _mapper.Map<User>(createDto);

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            var userDto = _mapper.Map<UserDto>(user);
            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, userDto);
        }

        [HttpPut("users/{id}")]
        public async Task<IActionResult> UpdateUser(int id, UpdateUserDto updateDto)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
                return NotFound();

            _mapper.Map(updateDto, user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("users/{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
                return NotFound();

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
