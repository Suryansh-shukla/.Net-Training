using System.ComponentModel.DataAnnotations;

namespace EFCoreMVCWebDEmo.Models
{
    public class Department
    {
        [Key]
        public int DeptId {  get; set; }
        [Required(ErrorMessage ="Name Is Mandatory")]
        public string? Name { get; set; }
        [Required(ErrorMessage ="LOcation is Required")]
        public string? Location { get; set; }
        //One to Many Relationship
        public ICollection<Employee>? Employees { get; set; }
    }
}
