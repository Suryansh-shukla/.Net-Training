using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        [Required(ErrorMessage = "Mandatory")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Mandatory")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Mandatory")]
        public string Condition { get; set; }
        [Required(ErrorMessage = "Mandatory")]
        public DateTime AppointmentDate { get; set; }
        [Required(ErrorMessage = "Mandatory")]
        // Foreign key to Doctor
        public int DoctorId { get; set; }
    }
}