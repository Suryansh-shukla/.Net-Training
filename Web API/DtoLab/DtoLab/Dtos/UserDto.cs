using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DtoLab.Dtos
{

    public class UserDto
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Age { get; set; }  // Computed from DOB
        public string? ProfileImageUrl { get; set; }
    }

    // Admin DTO - more fields for admin users
    public class UserAdminDto
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public bool IsAdmin { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime DateOfBirth { get; set; }
        // Still NO password or SSN!
    }

    // Create/Update DTOs - what the client sends
    public class CreateUserDto
    {
        [Required]
        public string Username { get; set; } = string.Empty;
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        [PasswordPropertyText]
        public string Password { get; set; } = string.Empty;  // Client sends password
        [Required]
        public DateTime DateOfBirth { get; set; }
    }

    public class UpdateUserDto
    {
        public string? Email { get; set; }
        public string? ProfileImageUrl { get; set; }
    }

}