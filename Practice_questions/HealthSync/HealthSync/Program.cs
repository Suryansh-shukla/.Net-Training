using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSync
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        Console.WriteLine("Enter the Consultant ID: ");
                        string id= Console.ReadLine();
                        Console.WriteLine("Enter Monthly Stipend: ");
                        decimal stipend = Convert.ToDecimal(Console.ReadLine());
                        Consultant Inhouse= new In_House(id,stipend);
                        Inhouse.ProcessPayment();
                    }
                    else if(choice == 2)
                    {
                        Console.WriteLine("Enter the Consultant ID: ");
                        string id = Console.ReadLine();
                        Console.WriteLine("Enter Rate per visit: ");
                        decimal rate = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Enter number of visits: ");
                        int visits = Convert.ToInt32(Console.ReadLine());
                        Consultant visiting = new Visiting(rate,visits,id);
                        visiting.ProcessPayment();
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
