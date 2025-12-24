namespace ConsoleApp1;
//using conditional logic to find largest of three numbers
public class LargestOfThree
{
    public int FindLargest(int num1, int num2, int num3)
    {
        if (num1 >= num2 && num1 >= num3)
        {
            return num1;
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            return num2;
        }
        else
        {
            return num3;
        }
    }
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