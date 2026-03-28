using Microsoft.EntityFrameworkCore;
using UniversityApi.Data;
using UniversityApi.Interfaces;
using UniversityApi.Models;

namespace UniversityApi.Repositories
{
    public class InstructorRepository : IInstructor
    {
        // Implement your code here  
        private readonly UniversityContext _context;
        public InstructorRepository(UniversityContext context)
        {
            _context = context;
        }
        public bool AddInstructor(Instructor instructor)
        {
            _context.Instructors.Add(instructor);
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<Instructor> GetInstructorsWithCourseCountAbove(int count)
        {
            return _context.Instructors.Where(i=>i.InstructorCourses.Count>count).ToList();
            //throw new NotImplementedException();
        }

        public IEnumerable<Instructor> GetInstructorsWithMostEnrollments()
        {
            var max= _context.InstructorCourses.Select(i=>i.Course.Enrollments.Count).Max();
            return _context.Instructors.Where(i=>i.InstructorCourses.Any(ic=>ic.Course.Enrollments.Count==max)).ToList();
            //throw new NotImplementedException();
        }
    }
}
