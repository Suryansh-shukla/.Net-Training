// See https://aka.ms/new-console-template for more information
using System;
namespace day6demo3
{
    public class Program
    {
        // public double radius;
        // public double CalculateArea()
        // {
        //     return Math.PI * radius * radius;
        // }
        // public static void Main()
        // {
        //     Program program = new Program();
        //     Console.WriteLine("Enter the radius of the circle:");
        //     program.radius = double.Parse(Console.ReadLine());
        //     double area = program.CalculateArea();
        //     Console.WriteLine($"Area of the circle: {Math.Round(area, MidpointRounding.AwayFromZero)}");
        // }

        // public static void Main()
        // {
        //     FeetToCentimeter feetToCentimeter = new FeetToCentimeter();
        //     Console.WriteLine("Enter the value in feet:");
        //     feetToCentimeter.feet = int.Parse(Console.ReadLine());
        //     double centimeter = feetToCentimeter.ConvertFeetToCentimeter();
        //     Console.WriteLine($"Value in centimeters: {Math.Round(centimeter,MidpointRounding.AwayFromZero)}");
        // }
        // public static void Main(){
        //     HeightCategory heightCategory = new HeightCategory();
        //     Console.WriteLine("Enter Height in CM:");
        //     heightCategory.heightCM=int.Parse(Console.ReadLine());
        //     string category=heightCategory.GetHeightCategory();
        //     Console.WriteLine($"Height Category: {category}");
        // }
        LargestOfThree largestOfThree=new LargestOfThree();
        public static void Main(){
            LargestOfThree largestOfThree=new LargestOfThree();
            Console.WriteLine("Enter first number:");
            largestOfThree.num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            largestOfThree.num2=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number:");
            largestOfThree.num3=int.Parse(Console.ReadLine());
            int largest=largestOfThree.FindLargest();
            Console.WriteLine($"Largest Number: {largest}");
        }
    }
}