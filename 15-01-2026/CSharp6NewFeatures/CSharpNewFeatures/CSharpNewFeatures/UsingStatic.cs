using static System.Console;
using static CSharpNewFeatures.MySelf;	/* Magic happens here */
using static CSharpNewFeatures.YourSelf;
namespace CSharpNewFeatures
{
    class UsingStatic
    {
        static void Main(string[] args)
        {
            //WhoAmI();
            //ReadKey();
            MySelf m1 = new MySelf();
            MySelf m2 = new MySelf();
            MySelf m3 = new MySelf();

            //Calling nonstatic methods
            m1.Display();
            m2.Display();
            m3.Display();

            //calling static Method
            WhoAmI();

            ShowMe("Alok");
            ShowMe("Rajat");
            ShowMe("Riya");



        }
    }
    class MySelf
    {
        public MySelf()
        {
            System.Console.WriteLine("Instance Class Constructor.");
        }
        public static void WhoAmI()//Static Method
        {
            WriteLine("C# 6.0 New Feature!");
        }

        public void Display()//Non Static Method
        {
           WriteLine("Sample on Static");
        }
    }

    static class YourSelf
    {
        static YourSelf()
        {
            System.Console.WriteLine("Static class Constructor Invoked");

        }

       public static void ShowMe(string userName)
        {
            System.Console.WriteLine("Welcome "+userName);
        }
    }
}
