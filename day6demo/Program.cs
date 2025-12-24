// See https://aka.ms/new-console-template for more information
using System;
namespace day6demo
{
    public class Program
    {
        public static void Main()
        {
            string title;
            string author;
            int num_pages;
            DateTime dueDate;
            DateTime returnedDate;
            Console.WriteLine("Enter Book Title:");
            title=Console.ReadLine();
            Console.WriteLine("Enter Book Author:");
            author=Console.ReadLine();
            Console.WriteLine("Enter Number of Pages:");
            num_pages=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Due Date (yyyy-MM-dd):");
            dueDate=DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Returned Date (yyyy-MM-dd):");
            returnedDate=DateTime.Parse(Console.ReadLine());
            Book book=new Book(title,author,num_pages,dueDate,returnedDate);
            Console.WriteLine("Enter number of days you plan to read the book:");
            int daysToRead=int.Parse(Console.ReadLine());
            double avgPagesPerDay=book.AveragePagesReadPerDay(daysToRead);
            Console.WriteLine($"Average Pages Read Per Day: {avgPagesPerDay}");
            Console.WriteLine("Enter daily late fee rate:");
            double dailyLateFeeRate=double.Parse(Console.ReadLine());
            double lateFee=book.CalculateLateFee(dailyLateFeeRate);
            Console.WriteLine($"Late Fee: {lateFee}");
        }
    }

}
