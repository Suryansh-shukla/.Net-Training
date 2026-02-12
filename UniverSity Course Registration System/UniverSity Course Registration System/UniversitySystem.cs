using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    // =========================
    // University System Class
    // =========================
    public class UniversitySystem
    {
        public Dictionary<string, Course> AvailableCourses { get; private set; }
        public Dictionary<string, Student> Students { get; private set; }
        public List<Student> ActiveStudents { get; private set; }

        public UniversitySystem()
        {
            AvailableCourses = new Dictionary<string, Course>();
            Students = new Dictionary<string, Student>();
        }

        public void AddCourse(string code, string name, int credits, int maxCapacity = 50, List<string> prerequisites = null)
        {
            // TODO:
            // 1. Throw ArgumentException if course code exists
            // 2. Create Course object
            // 3. Add to AvailableCourses
            if(AvailableCourses.ContainsKey(code))
            {
                throw new ArgumentException("Course code already exists.");
            }
            else
            {
                Course CObj=new Course(code,name,credits,maxCapacity,prerequisites);
                AvailableCourses.Add(code,CObj);
            }
            //throw new NotImplementedException();
        }

        public void AddStudent(string id, string name, string major, int maxCredits = 18, List<string> completedCourses = null)
        {
            // TODO:
            // 1. Throw ArgumentException if student ID exists
            // 2. Create Student object
            // 3. Add to Students dictionary
            if(Students.ContainsKey(id))
            {
                throw new ArgumentException("Student Id already exists.");
            }
            else
            {
                Student SObj = new Student(id, name, major, maxCredits, completedCourses);
                Students.Add(id, SObj);
                ActiveStudents.Add(SObj);
            }
            //throw new NotImplementedException();
        }

        public bool RegisterStudentForCourse(string studentId, string courseCode)
        {
            // TODO:
            // 1. Validate student and course existence
            // 2. Call student.AddCourse(course)
            // 3. Display meaningful messages
            if(!Students.ContainsKey(studentId))
            {
                Console.WriteLine("Student does not exist.");
            }
            if(!AvailableCourses.ContainsKey(courseCode))
            {
                Console.WriteLine("Course does not exist.");
            }
            Student student = Students[studentId];
            bool result = student.AddCourse(AvailableCourses[courseCode]);
            if (result)
            {
                Console.WriteLine("Student Registered SUccessfully");
            }
            else
            {
                Console.WriteLine("Student Already Registered or Prerequisites not met or Max Credits Exceeded");
            }
            return result;
            //throw new NotImplementedException();
        }

        public bool DropStudentFromCourse(string studentId, string courseCode)
        {
            // TODO:
            // 1. Validate student existence
            // 2. Call student.DropCourse(courseCode)
            if (!Students.ContainsKey(studentId))
            {
                Console.WriteLine("Student does not exist.");
            }
            if(!AvailableCourses.ContainsKey(courseCode))
            {
                Console.WriteLine("Course does not exist.");
            }
            Student student = Students[studentId];
            bool isdrop=student.DropCourse(courseCode);
            if (isdrop)
            {
                Console.WriteLine("Student Dropped Successfully");
            }
            else
            {
                Console.WriteLine("Student is not registered in the course.");
            }
            return isdrop;
            //throw new NotImplementedException();
        }

        public void DisplayAllCourses()
        {
            // TODO:
            // Display course code, name, credits, enrollment info
            foreach (var courses in AvailableCourses)
            {
                foreach(var item in courses.Value.Prerequisites)
                {
                    Console.WriteLine($"Course Code: {courses.Value.CourseCode}, Course Name: {courses.Value.CourseName}, Credits: {courses.Value.Credits}, Enrollment: {courses.Value.CurrentEnrollment}/{courses.Value.MaxCapacity}");
                }
            }
            //throw new NotImplementedException();
        }

        public void DisplayStudentSchedule(string studentId)
        {
            // TODO:
            // Validate student existence
            // Call student.DisplaySchedule()
                if (!Students.ContainsKey(studentId))
                {
                    throw new KeyNotFoundException("Student does not exist.");
                }
            else
            {
                Student student = Students[studentId];
                student.DisplaySchedule();
            }
            //throw new NotImplementedException();
        }

        public void DisplaySystemSummary()
        {
            // TODO:
            // Display total students, total courses, average enrollment
            Console.WriteLine($"Total Students: {Students.Count}");
            Console.WriteLine($"Total Courses: {AvailableCourses.Count}");
            Console.WriteLine($"Average Enrollment: {(AvailableCourses.Count > 0 ? AvailableCourses.Values.Average(c => c.CurrentEnrollment) : 0):F2}");
            //throw new NotImplementedException();
        }
    }
}
