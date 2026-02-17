using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCourse
{
    internal class EnrollmentSystem<TStudent, TCourse> 
        where TStudent : IStudent
     where TCourse : ICourse
    {
        private Dictionary<TCourse, List<TStudent>> _enrollments=new();
        public bool EnrollStudent(TStudent student, TCourse course)
        {
            if (!_enrollments.ContainsKey(course))
            {
                _enrollments[course] = new List<TStudent>();
            }
            if (_enrollments[course].Count >= course.MaxCapacity)
            {
                return false; // Course is full
            }
            if(_enrollments[course].Any(s => s.StudentId == student.StudentId))
            {
                return false; // Student already enrolled
            }
            _enrollments[course].Add(student);
            return true;
        }
        public IReadOnlyList<TStudent> GetEnrolledStudents(TCourse course)
        {
            if (_enrollments.ContainsKey(course))
            {
                return _enrollments[course].AsReadOnly();
            }
            return new List<TStudent>().AsReadOnly();
        }
        public IEnumerable<TCourse> GetStudentCourses(TStudent student)
        {
            return _enrollments.Where(kvp => kvp.Value.Any(s => s.StudentId == student.StudentId))
                               .Select(kvp => kvp.Key);
        }
        public int CalculateStudentWorkload(TStudent student)
        {
            return _enrollments.Where(kvp => kvp.Value.Any(s => s.StudentId == student.StudentId))
                               .Sum(kvp => kvp.Key.Credits);
        }
    }

}
