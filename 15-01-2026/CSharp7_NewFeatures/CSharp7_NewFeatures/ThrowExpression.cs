using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7_NewFeatures
{
    class ThrowExpression
    {
        static void Main(string[] args)
        {
            var a = Divide(10, 0);
        }
        public static double Divide(int x, int y)
        {
            //Directly throwing DivideByZeroException from expression
            return y != 0 ? x % y : throw new DivideByZeroException();
            //int result = 0;
            //if(y!=0)
            // {
            //    result= x % y;
            // }
            //else
            // {
            //     throw new DivideByZeroException();
            // }
        }
    }
}
