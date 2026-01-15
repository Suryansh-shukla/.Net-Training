using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CSharpNewFeatures
{
    class ExpressionBodiedFunction
    {
        private static void Main(string[] args)
        {
            double x = 1.618;
            double y = 3.142;


            WriteLine(AddNumbers(x, y));
            WriteLine(AddMeOld(10, 20));
            WriteLine(AddMe(5, 6));

            WriteLine(GreetUser("Pankaj"));
            ReadLine();
        }

        /* Expression bodied function */
        private static double AddNumbers(double x, double y) => x + y;
        

        public static int AddMeOld(int x, int y)
        {            
            return x + y;
        }

        public static int AddMe(int x, int y) =>  x + y ;

        public static string GreetUser(string userName) => "Welcome " + userName;

    }
}
