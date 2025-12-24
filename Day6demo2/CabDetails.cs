using System;
namespace Day6demo2;

public class CabDetails:Cab
{
    public bool ValidateBookingID()
    {
        //1. Booking id Length should be 6.
        // 2. The id should have AC before the character @
        // 3. There should be 3 digits after the character @.
        // For Example : AC@123
        if (BookingID.Length != 6)
        {
            return false;
        }
        if (!BookingID.StartsWith("AC@"))
        {
            return false;
        }
        string digitsPart = BookingID.Substring(3);
        if (digitsPart.Length != 3 || !int.TryParse(digitsPart, out _))
        {
            return false;
        }
        return true;
    }
     /*public double CalculateFareAmount()
 This method is used to calculate the fare of the cab bookings based on the cab type and return the fare amount with two decimal places.
 Refer the below given procedures to calculate fare.
 Hint : Use Math.Floor
Formula :
Fare = Distance * Price per km + Waiting Charge
Waiting Charge = Square root of Waiting Time
    Cab Type
   Price per km
     Hatchback
   10
     Sedan
   20
     SUV
   30
  Note : Cab type is case sensitive.*/    
  public double CalculateFareAmount()
    {
        double fare = 0;
        double waitingCharge = Math.Sqrt(WaitingTime);
        Repeat_Switch:
        switch (CabType)
        {
            case "Hatchback":
                fare = Distance * 10 + waitingCharge;
                break;
            case "Sedan":
                fare = Distance * 20 + waitingCharge;
                break;
            case "SUV":
                fare = Distance * 30 + waitingCharge;
                break;
            default:
                Console.WriteLine("Invalid Cab Type");
                Console.WriteLine("Re-enter Cab Type:");
                CabType = Console.ReadLine();
                goto Repeat_Switch;
        }
        return Math.Floor(fare * 100) / 100;
    }
}