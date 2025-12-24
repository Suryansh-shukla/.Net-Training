namespace day6demo3;

public class FeetToCentimeter
{
    public int feet;
    public double centimeter;

    public double ConvertFeetToCentimeter()
    {
        centimeter = feet * 30.48;
        return centimeter;
    }
    public static void Main()
        {
            FeetToCentimeter feetToCentimeter = new FeetToCentimeter();
            Console.WriteLine("Enter the value in feet:");
            feetToCentimeter.feet = int.Parse(Console.ReadLine());
            double centimeter = feetToCentimeter.ConvertFeetToCentimeter();
            Console.WriteLine($"Value in centimeters: {Math.Round(centimeter,MidpointRounding.AwayFromZero)}");
        }
}
