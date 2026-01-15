using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharp7_NewFeatures
{
    class OutVariableImpro
    {
        static void Main(string[] args)
        {
            ////Till C#-6.0
            //string rollNoData = "1001";
            //int rollNo; //Need to declare the variable first before we use
            //if (int.TryParse(rollNoData, out rollNo))
            //{
            //    WriteLine($"Conversion Successful!");                
            //}
            //WriteLine($"rollNo is {rollNo}");

            //Now in C#-7.0+
            string rollNoData = "10011";
            //No need to declare variable before we use, you can directly use it 
            if (int.TryParse(rollNoData, out var rollNo))
            {
                WriteLine($"Conversion Successful!");
            }
            //Variable declared inside if, can also be used outside if scope
            WriteLine($"rollNo is {rollNo}");

            Console.ReadKey();
        }
    }
}
