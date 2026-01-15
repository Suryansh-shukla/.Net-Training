using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharpNewFeatures
{
    class StringInterpolation
    {
        private static void Main(string[] args)
        {
            string name = "Sheldon";
            string planet = "Earth";

            /* Magic happens here */
            //WriteLine("{0} is actually named after {1}",planet,name);
            WriteLine($"{planet} is actually named after {name}");

            name = "Rahul Shah";
            double salary = 1000;
            WriteLine("{0}'s monthly salary is {1:C3}", name, salary); //Old Way

            WriteLine($"{name}'s monthly salary is {salary:C2}");//New way

            WriteLine($"Man! This {name} is kind of a {(salary >= 1000 ? "rich guy" : "poor guy")}");
            ReadLine();
        }

    }
}
