using System;
using LPU_Common;
using LPU_DAL;
using LPU_Entity;
namespace LPU_UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericClass<int> genericClass = new GenericClass<int>();
            int a = 10;
            int b = 20;
            Console.WriteLine($"Before Swap: a = {a}, b = {b}");
            genericClass.SwapMe(ref a, ref b);
            Console.WriteLine($"After Swap: a = {a}, b = {b}");
        }
    }
}