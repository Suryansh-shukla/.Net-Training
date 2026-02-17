using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCourse
{
    public class GradeBook<TStudent, TCourse>
         //where TStudent : IStudent
         //where TCourse : ICourse
    {
        private Dictionary<(TStudent, TCourse), double> _grades = new;
    }
}
