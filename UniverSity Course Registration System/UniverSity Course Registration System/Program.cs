using System;
using System.Collections.Generic;
using System.Linq;

namespace University_Course_Registration_System
{
     // =========================
    // Program (Menu-Driven)
    // =========================
    class Program
    {
        static void Main()
        {
            UniversitySystem system = new UniversitySystem();
            bool exit = false;

            Console.WriteLine("Welcome to University Course Registration System");

            while (!exit)
            {
                Console.WriteLine("\n1. Add Course");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Register Student for Course");
                Console.WriteLine("4. Drop Student from Course");
                Console.WriteLine("5. Display All Courses");
                Console.WriteLine("6. Display Student Schedule");
                Console.WriteLine("7. Display System Summary");
                Console.WriteLine("8. Exit");

                Console.Write("Enter choice: ");
                string choice = Console.ReadLine() ?? string.Empty;

                try
                {
                    // TODO:
                    // Implement menu handling logic using switch-case
                    // Prompt user inputs
                    // Call appropriate UniversitySystem methods
                    switch (choice)
                    {
                        case "1":
                            {
                                Console.Write("Enter course code: ");
                                string code = Console.ReadLine() ?? string.Empty;
                                Console.Write("Enter course name: ");
                                string name = Console.ReadLine() ?? string.Empty;
                                Console.Write("Enter credits: ");
                                int credits = Convert.ToInt32(Console.ReadLine() ?? "0");
                                Console.Write("Enter capacity: ");
                                int capacity = Convert.ToInt32(Console.ReadLine() ?? "0");
                                Console.Write("Enter prerequisites (comma-separated): ");
                                string prereqInput = Console.ReadLine() ?? string.Empty;
                                List<string> prerequisites = prereqInput
                                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(p => p.Trim())
                                    .ToList();
                                break;
                            }
                        case "2":
                            {

                                break;
                            }
                        case "3":
                            {
                                break;
                            }
                        case "4":
                            {
                                break;

                            }
                        case "5":
                            {
                                break;
                            }
                        case "6":
                            {
                                break;
                            }
                        case "7":
                            {
                                break;
                            }
                        case "8":
                            {
                                break;
                            }
                        default:
                            {
                                break;
                            }

                    }
                }
                catch(FormatException)
                {
                    Console.WriteLine("Invalid input format. Please try again.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}

