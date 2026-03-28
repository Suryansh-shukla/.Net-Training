using Microsoft.EntityFrameworkCore;
using UniversityApi.Data;
using UniversityApi.Interfaces;
using UniversityApi.Models;

namespace UniversityApi.Repositories
{
    public class StudentRepository : IStudent
    {
        // Implement your code here  
        private readonly UniversityContext _context;
        public StudentRepository(UniversityContext context)
        {
            _context = context;

        }
        public bool DeleteStudent(int studentId)
        {
            var student = _context.Students.FirstOrDefault(x => x.StudentId == studentId);
            if (student == null) { return false; }

            _context.Students.Remove(student);
            _context.SaveChanges();
            return true;
            //throw new NotImplementedException();
        }

        public IEnumerable<Student> GetStudentsByCourseTitle(string courseTitle)
        {
            return _context.Students
                .Where(s => s.Enrollments.Any(e => e.Course.Title == courseTitle))
                .ToList();
            //throw new NotImplementedException();
        }
    }
}
