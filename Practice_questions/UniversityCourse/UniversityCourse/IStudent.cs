using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCourse
{
    public interface IStudent
    {
        int StudentId { get;  }
        string Name { get; }
        int Semester { get; }
    }
}
