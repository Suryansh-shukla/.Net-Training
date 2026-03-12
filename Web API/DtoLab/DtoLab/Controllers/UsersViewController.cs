using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using DtoLab.Data;
using DtoLab.ViewModels;

namespace DtoLab.Controllers
{
    public class UsersViewController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public UsersViewController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: UsersView
        public async Task<IActionResult> Index(string searchTerm, bool adminsOnly)
        {
            var query = _context.Users.AsQueryable();

            // Apply filters
            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(u =>
                    u.Username.Contains(searchTerm) ||
                    u.Email.Contains(searchTerm));
            }

            if (adminsOnly)
            {
                query = query.Where(u => u.IsAdmin);
            }

            var users = await query.ToListAsync();

            // Map to ViewModels
            var userProfiles = users.Select(u => new UserProfileViewModel
            {
                Id = u.Id,
                Username = u.Username,
                Email = u.Email,
                Age = CalculateAge(u.DateOfBirth),
                MemberSince = u.CreatedAt.ToString("MMMM yyyy"),
                ProfileImageUrl = u.ProfileImageUrl,
                IsBirthdayMonth = u.DateOfBirth.Month == DateTime.Now.Month
            }).ToList();

            var viewModel = new UserListViewModel
            {
                Users = userProfiles,
                SearchTerm = searchTerm,
                ShowAdminsOnly = adminsOnly,
                TotalUsers = userProfiles.Count
            };

            return View(viewModel);
        }

        // GET: UsersView/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
                return NotFound();

            var viewModel = new UserProfileViewModel
            {
                Id = user.Id,
                Username = user.Username,
                Email = user.Email,
                Age = CalculateAge(user.DateOfBirth),
                MemberSince = user.CreatedAt.ToString("MMMM dd, yyyy"),
                ProfileImageUrl = user.ProfileImageUrl,
                IsBirthdayMonth = user.DateOfBirth.Month == DateTime.Now.Month
            };

            return View(viewModel);
        }

        // GET: UsersView/Register
        public IActionResult Register()
        {
            return View(new RegisterViewModel());
        }

        // POST: UsersView/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                // Map ViewModel to Entity
                var user = new Models.User
                {
                    Username = viewModel.Username,
                    Email = viewModel.Email,
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword(viewModel.Password),
                    DateOfBirth = viewModel.DateOfBirth,
                    CreatedAt = DateTime.UtcNow
                };

                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                // Redirect to profile page
                return RedirectToAction(nameof(Details), new { id = user.Id });
            }

            // If we got this far, something failed; redisplay form
            return View(viewModel);
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
