using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelsDemo.Models
{

    public class Employee
    {
        [Required]
        [Remote("CheckIdExists","Home",ErrorMessage="Id already exists")]
        public int Id { get; set; }

        [Required(ErrorMessage="Employee Name is mandatory")]
        [RegularExpression(@"[a-zA-Z\s]+$",ErrorMessage="Invalid Name")]
        public string Name { get; set; }
        
        [StringLength(10,ErrorMessage="Only 10 characters allowed")]
        public string Designation { get; set; }
        
        [Range(21,56,ErrorMessage="Age must be between 21")]
        public int Age { get; set; }
        
        [DisplayName("Joining Date")]
        [DataType(DataType.Date,ErrorMessage="Invalid Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}")]
        [Required(ErrorMessage="Joining Date is mandatory")]
        public DateTime DateOfJoining { get; set; }
        
        [EmailAddress(ErrorMessage="Invalid E-MailId")]
        public string Email { get; set; }
    }

}