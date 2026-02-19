using System;
using FlexibleInventorySystem_Practice.Services;
using FlexibleInventorySystem_Practice.Models;


namespace FlexibleInventorySystem_Practice
{
    /// <summary>
    /// TODO: Implement console user interface
    /// </summary>
    class Program
    {
        private static InventoryManager _inventory = new InventoryManager();

        static void Main(string[] args)
        {
            // TODO: Display menu and handle user input
            // Options should include:
            // 1. Add Product
            // 2. Remove Product
            // 3. Update Quantity
            // 4. Find Product
            // 5. View All Products
            // 6. Generate Reports
            // 7. Check Low Stock
            // 8. Exit

            while (true)
            {
                DisplayMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddProductMenu();
                        break;
                    case "2":
                        RemoveProductMenu();
                        break;
                    // TODO: Implement other cases

                    case "3":
                        // Update Quantity
                        UpdateQuantity();
                        break;
                    case "4":
                        FindProduct();
                        break;
                    case "5":
                        ShowAllProducts();
                        break;
                    case "6":
                        GenerateReports();
                        break;
                    case "7":
                        checkLowStock();
                        break;
                    case "8":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        private static void checkLowStock()
        {
            throw new NotImplementedException();
        }

        private static void GenerateReports()
        {
            throw new NotImplementedException();
        }

        private static void ShowAllProducts()
        {
            throw new NotImplementedException();
        }

        private static void FindProduct()
        {
            throw new NotImplementedException();
        }

        private static void UpdateQuantity()
        {
            throw new NotImplementedException();
        }

        static void DisplayMenu()
        {
            // TODO: Display formatted menu
            throw new NotImplementedException();
        }

        static void AddProductMenu()
        {
            // TODO: Implement menu to add different product types
            // Ask user for product type
            // Collect appropriate properties
            // Add to inventory
            Console.WriteLine("Select product type to add:\n1. Electronic\n2. Groceries\n3. Clothing");
            string choice = Console.ReadLine();
            if(choice == "1")
            {
                Product product = new ElectronicProduct();
                Console.WriteLine("Enter product ID:");
                product.Id = Console.ReadLine();
                Console.WriteLine("Enter product name:");
                product.Name = Console.ReadLine();


            }
            else if(choice == "2")
            {
            }
            else if(choice == "3")
            {
            }
            else
            {
                Console.WriteLine("Invalid option. Returning to main menu.");
            }

            throw new NotImplementedException();
        }

        static void RemoveProductMenu()
        {
            // TODO: Implement product removal
            throw new NotImplementedException();
        }

        // TODO: Add other menu methods
    }
}