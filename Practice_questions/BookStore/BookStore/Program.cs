using BookStore;
using System;

class Program
{
    static void Main()
    {
        try
        {
            // Read initial input
            string[] input = Console.ReadLine().Split();

            Book book = new Book
            {
                ID = input[0],
                Title = input[1],
                Price = int.Parse(input[2]),
                Stock = int.Parse(input[3])
            };

            BookUtility utility = new BookUtility(book);

            bool exit = false;

            while (!exit)
            {
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.GetBookDetails(book);
                        break;

                    case 2:
                        int newPrice = int.Parse(Console.ReadLine());
                        utility.UpdateBookPrice(newPrice);
                        break;

                    case 3:
                        int newStock = int.Parse(Console.ReadLine());
                        utility.UpdateBookStock(newStock);
                        break;

                    case 4:
                        Console.WriteLine("Thank You");
                        exit = true;
                        break;
                }
            }
        }
        catch (InvalidBookDataException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid Input");
        }
    }
}
