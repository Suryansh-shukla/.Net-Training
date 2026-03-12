namespace DtoLab.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;  // 😱 Sensitive!
        public string SocialSecurityNumber { get; set; } = string.Empty;  // 😱 Very sensitive!
        public DateTime DateOfBirth { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? ProfileImageUrl { get; set; }

    }
}
