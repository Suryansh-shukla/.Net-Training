using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7_NewFeatures
{
    class LocalFunctions
    {
        public int CalculateSomething(int a, int b)
        {
            int sum = Sum(a, b);
            int difference = Difference(a, b);

            return sum * difference;

            int Sum(int x, int y)
            {
                return x + y;
            }

            int Difference(int x, int y)
            {
                return x - y;
            }
        }
        public void DoSomeThing()
        {
            DoTask1("Riya");
            void DoTask1(string userName)
            {
                Console.WriteLine("Welcome "+userName);
            }
        }

        static void Main(string[] args)
        {
            LocalFunctions obj = new LocalFunctions();
            Console.WriteLine($"Result:  {obj.CalculateSomething(6, 4)}");
            obj.DoSomeThing();
        }
    }
}
