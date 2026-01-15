using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7_NewFeatures
{
    class Student1
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

    }

    class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public int duration { get; set; }
        public int Fees { get; set; }
    }

    class Enrollment
    {
        public int ID { get; set; }
        public int RollNo { get; set; }
        public string PaymentMode { get; set; }
        public int CourseID { get; set; }
    }


    class StudentVM//ViewModel Class
    {
        //Student
        public int RollNo { get; set; }
        public string Name { get; set; }

        //Course
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public int Fees { get; set; }

        //Enrollment
        public int ID { get; set; }
        public string PaymentMode { get; set; }

    }

    class Tuples_Demo
    {
        //return type of the method is tuple here with 3 double parameters
        private static (double, double, double) GetResult(List<double> numbers)
        {
            return (numbers.Min(), numbers.Max(), numbers.Average());
        }

        //tuple with 3 params & named return parameters. Ex- (double Min, double Max, double Avg)
        //private static (double Min, double Max, double Avg) GetResult(List<double> numbers)
        //{
        //    return (numbers.Min(), numbers.Max(), numbers.Average());
        //}

        //New Way
        public static (Student1,Course,Enrollment) GetNewEnrolledStudentDetails(int rollNo)
        {
            Student1 s1 = new Student1();
            s1.Name = "Alok";
            s1.RollNo = 101;
            s1.Address = "805,Dafodill Society,Wakad,Pune";

            Course c1 = new Course();
            c1.CourseID = 1;
            c1.CourseName = "Csharp Basics";
            c1.duration = 7;
            c1.Fees = 12000;

            Enrollment enroll = new Enrollment();
            enroll.ID = 1234;
            enroll.RollNo = s1.RollNo;
            enroll.CourseID = c1.CourseID;
            enroll.PaymentMode = "CreditCard";

            return (s1, c1,enroll);
        }

        //Old Way
        public static StudentVM GetEnrolledStudentDetails(int rollNo)
        {
            StudentVM studObj = new StudentVM();

            Student1 s1 = new Student1();
            s1.Name = "Alok";
            s1.RollNo = 101;
            s1.Address = "805,Dafodill Society,Wakad,Pune";

            Course c1 = new Course();
            c1.CourseID = 1;
            c1.CourseName = "Csharp Basics";
            c1.duration = 7;
            c1.Fees = 12000;

            Enrollment enroll = new Enrollment();
            enroll.ID = 1234;
            enroll.RollNo = s1.RollNo;
            enroll.CourseID = c1.CourseID;
            enroll.PaymentMode = "CreditCard";

            //Passing Values to VM class
            //setting student Values
            studObj.RollNo = s1.RollNo;
            studObj.Name = s1.Name;

            //Setting Course
            studObj.CourseID = c1.CourseID;
            studObj.CourseName = c1.CourseName;
            studObj.Fees = c1.Fees;
            //Setting enrollment
            studObj.ID = enroll.ID;
            studObj.PaymentMode = enroll.PaymentMode;

            return studObj ;
        }
        static void Main(string[] args)
        {
            List<double> numbers = new List<double> { 52, 45, 120, 56, 98, 304, 20, 69 };

            var res = GetResult(numbers);
            Console.WriteLine($"Lowest: {res.Item1}, Highest:{res.Item2}, Average:{res.Item3}");
            //OR            
            //Console.WriteLine($"Lowest: {res.Min}, Highest:{res.Max}, Average:{res.Avg}");

            //OR
            //Tuple Deconstruction by using type and name of return parameter inside of parentheses:
            (double l, double h, double a) = GetResult(numbers);
            Console.WriteLine($"Lowest: {l}, Highest:{h}, Average:{a}");

          var myStudent=  GetEnrolledStudentDetails(101);//VM is Returned

            var stud = GetNewEnrolledStudentDetails(101);//Returning Tuple

            Console.ReadKey();
        }
    }
}
