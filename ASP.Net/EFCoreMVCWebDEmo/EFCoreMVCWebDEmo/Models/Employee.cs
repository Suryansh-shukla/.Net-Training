using System.ComponentModel.DataAnnotations;

namespace EFCoreMVCWebDEmo.Models
{
    public class Employee
    {
        [Key]
        public int EmpID { get; set; }
        [Required(ErrorMessage="Name is Mandatory")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Age is Mandatory")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Address is Mandatory")]
        public string? Address { get; set; }
        [Required(ErrorMessage = "Department Id reference is Mandatory")]
        public int DeptId { get; set; }
        //Navigation Property
        //public virtual Department? Department { get; set; }
    }
}
