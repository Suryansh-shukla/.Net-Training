using System.ComponentModel.DataAnnotations;

namespace MVC_Core_Web_App.Models
{
    public class Student
    {
        [Required(ErrorMessage = "RollNo can't be left Blank")]
        public int RollNo { get; set; }
        [Required(ErrorMessage = "Name can't be left Blank")]
        [StringLength(15,MinimumLength=2,ErrorMessage = "Name Min Length 2 and max Length is 15")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Age can't be left Blank")]
        [Range(18,60,ErrorMessage = "Age must be between 18 and 60")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Address can't be left Blank")]
        [StringLength(50,MinimumLength=5,ErrorMessage = "Address Min Length 5 and max Length is 30")]
        public string? Address { get; set; }
    }
}
