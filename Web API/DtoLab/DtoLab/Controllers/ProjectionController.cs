using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DtoLab.Data;
using DtoLab.Dtos;

namespace DtoLab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectionController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProjectionController(AppDbContext context)
        {
            _context = context;
        }

        // ✅ BEST: Project directly to DTO in query
        [HttpGet("users/{id}")]
        public async Task<ActionResult<UserDto>> GetUser(int id)
        {
            var userDto = await _context.Users
                .Where(u => u.Id == id)
                .Select(u => new UserDto
                {
                    Id = u.Id,
                    Username = u.Username,
                    Email = u.Email,
                    Age = CalculateAge(u.DateOfBirth),
                    ProfileImageUrl = u.ProfileImageUrl
                })
                .FirstOrDefaultAsync();

            if (userDto == null)
                return NotFound();

            return Ok(userDto);
        }

        [HttpGet("users")]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetUsers()
        {
            var userDtos = await _context.Users
                .Select(u => new UserDto
                {
                    Id = u.Id,
                    Username = u.Username,
                    Email = u.Email,
                    Age = CalculateAge(u.DateOfBirth),
                    ProfileImageUrl = u.ProfileImageUrl
                })
                .ToListAsync();

            return Ok(userDtos);
        }

        [HttpGet("users/by-email")]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetUsersByDomain(string domain)
        {
            var userDtos = await _context.Users
                .Where(u => u.Email.EndsWith($"@{domain}"))
                .Select(u => new UserDto
                {
                    Id = u.Id,
                    Username = u.Username,
                    Email = u.Email,
                    Age = CalculateAge(u.DateOfBirth)
                })
                .ToListAsync();

            return Ok(userDtos);
        }
        [HttpGet("users/{userId}/orders")]
        public async Task<ActionResult<IEnumerable<OrderDto>>> GetUserOrders(int userId)
        {
            var orders = await _context.Orders
                .Where(o => o.UserId == userId)
                .Select(o => new OrderDto
                {
                    Id = o.Id,
                    OrderDate = o.OrderDate,
                    TotalAmount = o.TotalAmount,
                    Status = o.Status,
                    CustomerName = o.User.Username,
                    Items = o.OrderItems.Select(i => new OrderItemDto
                    {
                        ProductName = i.ProductName,
                        UnitPrice = i.UnitPrice,
                        Quantity = i.Quantity
                    }).ToList()
                })
                .ToListAsync();

            return Ok(orders);
        }

        // Anonymous type projection (useful for one-off queries)
        [HttpGet("users/summary")]
        public async Task<ActionResult> GetUserSummaries()
        {
            var summaries = await _context.Users
                .Select(u => new
                {
                    u.Id,
                    u.Username,
                    u.Email,
                    IsAdult = CalculateAge(u.DateOfBirth) >= 18
                })
                .ToListAsync();

            return Ok(summaries);
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
