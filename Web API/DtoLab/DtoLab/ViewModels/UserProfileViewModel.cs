using System.ComponentModel.DataAnnotations;
namespace DtoLab.ViewModels
{
    public class UserProfileViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Username")]
        public string Username { get; set; } = string.Empty;

        [Display(Name = "Email Address")]
        public string Email { get; set; } = string.Empty;

        [Display(Name = "Age")]
        public int Age { get; set; }

        [Display(Name = "Member Since")]
        public string MemberSince { get; set; } = string.Empty;

        [Display(Name = "Profile Picture")]
        public string? ProfileImageUrl { get; set; }

        // UI-specific properties
        public bool IsBirthdayMonth { get; set; }
        public string DisplayName => Username;
        public string AvatarInitials => Username.Length > 0 ? Username.Substring(0, 1).ToUpper() : "?";
    }
    // ViewModel for user registration form
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Username is required")]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Username")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Display(Name = "Email")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } = string.Empty;

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; } = string.Empty;

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "I agree to terms")]
        [Range(typeof(bool), "true", "true", ErrorMessage = "You must agree to terms")]
        public bool AgreeToTerms { get; set; }
    }

    // ViewModel for user list with filtering
    public class UserListViewModel
    {
        public List<UserProfileViewModel> Users { get; set; } = new();
        public string? SearchTerm { get; set; }
        public string? SortBy { get; set; }
        public bool ShowAdminsOnly { get; set; }
        public int TotalUsers { get; set; }
    }
}
