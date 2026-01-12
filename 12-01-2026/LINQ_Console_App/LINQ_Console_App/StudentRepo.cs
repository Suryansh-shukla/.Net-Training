using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Console_App
{
    class StudentRepo
    {
        static List<Student> studList = null;
        public StudentRepo() 
        {
            if (studList == null)
            {
                studList = new List<Student>();
                studList.Add(new Student() { RollNo = 101, Name = "Suryansh Shukla", Gender = "Male", Marks = 85,Fees=1500 });
                studList.Add(new Student() { RollNo = 102, Name = "Harshita", Gender = "Female", Marks = 92, Fees = 1000 });
                studList.Add(new Student() { RollNo = 103, Name = "Aman Verma", Gender = "Male", Marks = 78, Fees = 1000 });
                studList.Add(new Student() { RollNo = 104, Name = "Priya Singh", Gender = "Female", Marks = 88 ,Fees = 2500 });
                studList.Add(new Student() { RollNo = 105, Name = "Rohit Kumar", Gender = "Male", Marks = 69,Fees = 1500 });
                studList.Add(new Student() { RollNo = 106, Name = "Neha Gupta", Gender = "Female", Marks = 91,Fees = 2000 });
                studList.Add(new Student() { RollNo = 107, Name = "Vikas Sharma", Gender = "Male", Marks = 74 ,Fees = 1000 });
                studList.Add(new Student() { RollNo = 108, Name = "Pooja Mishra", Gender = "Female", Marks = 86,Fees = 3000 });
                studList.Add(new Student() { RollNo = 109, Name = "Ankit Yadav", Gender = "Male", Marks = 80 ,Fees = 2500 });
                studList.Add(new Student() { RollNo = 110, Name = "Kajal Mehta", Gender = "Female", Marks = 95 ,Fees = 1800 });

            }
        }
        public List<Student> GetAllStudents()
        {
            return studList;
        }
    }
}
