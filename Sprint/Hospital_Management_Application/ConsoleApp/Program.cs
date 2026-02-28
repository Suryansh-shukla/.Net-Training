using Application;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                try
                {
                    Console.WriteLine("\n===== DOCTOR MANAGEMENT SYSTEM =====");
                    Console.WriteLine("1. Add Doctor");
                    Console.WriteLine("2. Exit");
                    Console.Write("Enter your choice: ");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Doctor doctor = new Doctor
                            {
                                DoctorId = 1,
                                Name = "Dr. John Doe",
                                Specialization = "Cardiology",
                                ConsultationFee = 150.00m
                            };

                            //AddDoctor(doctor);
                            break;

                        case 2:
                            exit = true;
                            Console.WriteLine("Exiting application...");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Try again.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred. Please try again.");

                    // Log exception
                    Logger.LogError(ex.Message, ex.StackTrace);
                }
            }
        }
    }
}