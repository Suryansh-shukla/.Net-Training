using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }
        [Required(ErrorMessage = "Mandatory")]
        public string Name { get; set; }=string.Empty;
        [Required(ErrorMessage = "Mandatory")]
        public string Specialization { get; set; }=string.Empty;
        [Required(ErrorMessage = "Mandatory")]
        public decimal ConsultationFee { get; set; }
    }
}