using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeOnRent_App
{
    public class Program
    {
        internal readonly static SortedDictionary<int, Bike> bikeDetails=new SortedDictionary<int, Bike>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Add Bike Details");
                Console.WriteLine("2. Group Bikes by Brand");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter your choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Bike Model:");
                        string model = Console.ReadLine();
                        Console.WriteLine("Enter Bike Brand:");
                        string brand = Console.ReadLine();
                        Console.WriteLine("Enter Price Per Day:");
                        int pricePerDay = Convert.ToInt32(Console.ReadLine());
                        BikeUtility bikeUtility = new BikeUtility();
                        bikeUtility.AddBikeDetails(model, brand, pricePerDay);
                        Console.WriteLine("Bike details added successfully.");
                        break;
                    case 2:
                        BikeUtility bikeUtil = new BikeUtility();
                        var groupedBikes = bikeUtil.GroupBikesByBrand();
                        foreach (var brandGroup in groupedBikes)
                        {
                            Console.WriteLine($"Brand: {brandGroup.Key}");
                            foreach (var bike in brandGroup.Value)
                            {
                                Console.WriteLine($"  Model: {bike.Model}, Price Per Day: {bike.PricePerDay}");
                            }
                        }
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;

                }
            }
        }
    }
}
