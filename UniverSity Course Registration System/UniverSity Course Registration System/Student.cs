using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    // =========================
    // Student Class
    // =========================
    public class Student
    {
        public string StudentId { get; private set; }
        public string Name { get; private set; }
        public string Major { get; private set; }
        public int MaxCredits { get; private set; }

        public List<string> CompletedCourses { get; private set; }
        public List<Course> RegisteredCourses { get; private set; }

        public Student(string id, string name, string major, int maxCredits = 18, List<string> completedCourses = null)
        {
            StudentId = id;
            Name = name;
            Major = major;
            MaxCredits = maxCredits;
            CompletedCourses = completedCourses ?? new List<string>();
            RegisteredCourses = new List<Course>();
        }

        public int GetTotalCredits()
        {
            // TODO: Return sum of credits of all RegisteredCourses
            int totalCredits = 0;
            foreach (var item in RegisteredCourses)
            {
                totalCredits += item.Credits;
            }
            return totalCredits;
            //throw new NotImplementedException();
        }

        public bool CanAddCourse(Course course)
        {
            // TODO:
            // 1. Course should not already be registered
            // 2. Total credits + course credits <= MaxCredits
            // 3. Course prerequisites must be satisfied
            int totCredits = 0;
            foreach (var item in RegisteredCourses)
            {
                totCredits += item.Credits;
                if (item.CourseCode == course.CourseCode)
                {
                    return false;
                }
            }
            if(totCredits+ course.Credits > MaxCredits)
            {
                return false;
            }
            foreach (var item in CompletedCourses)
            {
                if (!course.Prerequisites.Contains(item))
                {
                    return false;
                }
            }
            return true;
            //throw new NotImplementedException();
        }

        public bool AddCourse(Course course)
        {
            // TODO:
            // 1. Call CanAddCourse
            // 2. Check course capacity
            // 3. Add course to RegisteredCourses
            // 4. Call course.EnrollStudent()
            if(CanAddCourse(course) && !course.IsFull())
            {
                RegisteredCourses.Add(course);
                course.EnrollStudent();
                return true;
            }
            return false;
            //throw new NotImplementedException();
        }

        public bool DropCourse(string courseCode)
        {
            // TODO:
            // 1. Find course by code
            // 2. Remove from RegisteredCourses
            // 3. Call course.DropStudent()
            foreach(var item in RegisteredCourses)
            {
                if(item.CourseCode==courseCode)
                {
                    RegisteredCourses.Remove(item);
                    item.DropStudent();
                    return true;
                }
            }
            return false;
            //throw new NotImplementedException();
        }

        public void DisplaySchedule()
        {
            // TODO:
            // Display course code, name, and credits
            // If no courses registered, display appropriate message
            if(RegisteredCourses.Count>0)
            {
                foreach(var item in RegisteredCourses)
                {
                    Console.WriteLine($"Course Code: {item.CourseCode}, Course Name: {item.CourseName}, Credits: {item.Credits}");
                }
            }
            else
            {
                Console.WriteLine("No courses registered.");
            }
            throw new NotImplementedException();
        }
    }
}
