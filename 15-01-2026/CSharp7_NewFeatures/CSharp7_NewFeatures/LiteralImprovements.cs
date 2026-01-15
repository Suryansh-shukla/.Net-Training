using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7_NewFeatures
{
    class LiteralImprovements
    {
        static void Main(string[] args)
        {
            var lit1 = 478_1254_3698_44;        //Digit Separator
            var lit2 = 0Xa3_7e;                 //Hexadecimal literal
            var lit3 = 1100_1011_0100_1010_1001;//Binary literal
            Console.WriteLine($"lit1: {lit1}, lit2: {lit2}, lit3: {lit3}");
        }
    }
}
