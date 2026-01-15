using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CSharpNewFeatures
{
    class NameOfExpression
    {
        private static void Main(string[] args)
        {
            try
            {
                Student s1 = new Student();
                Console.WriteLine(s1.GetType());
                Console.WriteLine(typeof(Student));
                CallSomething();
            }
            catch (Exception exception)
            {
                WriteLine(exception.Message);
            }
            ReadKey();
        }
        private static void CallSomething()
        {
            int? BirthYear = null;
            if (BirthYear == null)
            {
                 //throw new Exception("BirthYear is null");
                 //throw new Exception("BornInYear is null");
                 throw new Exception(nameof(BirthYear) + " is null");
            }
        }

    }
}
