using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        [Required(ErrorMessage = "Mandatory")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Mandatory")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Mandatory")]
        public string Condition { get; set; }= string.Empty;
        [Required(ErrorMessage = "Mandatory")]
        public DateTime AppointmentDate { get; set; }
        [Required(ErrorMessage = "Mandatory")]
        // Foreign key to Doctor
        public int DoctorId { get; set; }
    }
}