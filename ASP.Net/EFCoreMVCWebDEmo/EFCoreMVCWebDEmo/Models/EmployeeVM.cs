using System.ComponentModel.DataAnnotations;

namespace EFCoreMVCWebDEmo.Models
{
    public class EmployeeVM
    {
        [Key]
        public int EmpID { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Address { get; set; }
        public int DeptId { get; set; }
    }
}
