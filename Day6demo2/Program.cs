// See https://aka.ms/new-console-template for more information
using System;
namespace Day6demo2
{
    public class Program
    {
        public static void Main()
        {
            CabDetails cabDetails=new CabDetails();
            Console.WriteLine("Enter Booking ID:");
            cabDetails.BookingID=Console.ReadLine();
            if(cabDetails.ValidateBookingID())
            {
                Console.WriteLine("Enter Cab Type:");
                cabDetails.CabType=Console.ReadLine();
                Console.WriteLine("Enter Distance (in km):");
                cabDetails.Distance=double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Waiting Time (in minutes):");
                cabDetails.WaitingTime=int.Parse(Console.ReadLine());
                double fareAmount=cabDetails.CalculateFareAmount();
                Console.WriteLine($"Fare Amount: {fareAmount:F2}");
            }
            else
            {
                Console.WriteLine("Invalid Booking ID");
            }
        }
    }
}