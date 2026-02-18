using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> courses = new Dictionary<string, int>
        {
            { "CSharp", 30 },
            { "SQL", 28 },
            { "Azure", 15 }
        };

        string cancelledCourse = Console.ReadLine();
        // TODO: Remove key if available and print remaining courses
if(courses.Remove(cancelledCourse))
		{
Console.WriteLine("Remove krrdiya bhai");
		}
		else
		{
Console.WriteLine("Ni ho payega bhai sorry");
		}	
foreach(var item in courses)
	{
					Console.WriteLine($"{item.Key} : {item.Value}");
	}
    }

}