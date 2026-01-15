using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7_NewFeatures
{
    class PatternMatching
    {
        static void Main(string[] args)
        {

            //Student student = new Student("Kamlesh", "Jadhav");
            List<Student> studList = new List<Student>()
            {
                new Student("Mayank","Maheshwari"),
                new Student("Alok","Shinde"),
                new Student("Rajat","Sharma"),
                null,
                new Student("Manish","Arora"),
                new Student("Maya","Reddy"),
                null,
                new Student("Neeraj","Jain"),
                new Student("Harish","Dasari"),
                null
            };
            // Student student=new Student("Mayank","Maheshwari");
            foreach (Student item in studList)
            {

                switch (item)
                {
                    //This is Constant pattern
                    case null: Console.WriteLine("It's Constant pattern"); break;
                    //This is a type pattern
                    case Student s when s.FirstName.StartsWith("M"): Console.WriteLine(s.FirstName); break;
                    //This is a var pattern with the type Student
                    case var x:
                        Console.WriteLine(x?.GetType().Name); break;
                }
            }
            Console.ReadKey();
        }
    }

    internal class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
     
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
