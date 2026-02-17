using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCourse
{
    public class EngineeringStudent:IStudent
    {
        public int StudentId { get; set;  }
        public string Name { get; set; }
        public int Semester { get; set; }
        public string Specialization { get; set; }
    }
}
