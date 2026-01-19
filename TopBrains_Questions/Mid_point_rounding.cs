using System;
class Program
{
    public static void Main()
    {
        double radius=Convert.ToDouble(Console.ReadLine());
        double area=Math.PI*radius*radius;
        double roundedArea=Math.Round(area,2,MidpointRounding.AwayFromZero);
        Console.WriteLine(roundedArea);
        }
}