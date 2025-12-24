// See https://aka.ms/new-console-template for more information
using System;
namespace day6demo3
{
    public class Program
    {
        public double radius;
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
        public static void Main()
        {
            Program program = new Program();
            Console.WriteLine("Enter the radius of the circle:");
            program.radius = double.Parse(Console.ReadLine());
            double area = program.CalculateArea();
            Console.WriteLine($"Area of the circle: {Math.Round(area, MidpointRounding.AwayFromZero)}");
        }

        
        
        
    }
}