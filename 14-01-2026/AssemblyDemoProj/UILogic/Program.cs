using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary;

namespace UILogic
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("Enter First Number :");
            num1= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number :");
            num2= Convert.ToInt32(Console.ReadLine());

            SomeLogic logic = new SomeLogic();

            
            int numResult=logic.AddMe(num1, num2);
            Console.WriteLine($"The Sum of {num1} and {num2} is : {numResult}");
            Console.ReadLine();
        }
    }
}
