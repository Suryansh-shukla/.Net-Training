using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("1.Add 2.Search 3.Update 4.Delete 5.Exit");
            int choice = int.Parse(Console.ReadLine());
            // TODO: Implement menu operations using dictionary
switch(choice)
{
case 1:
{
Console.Write("Enter Name: ");
string Name=Console.ReadLine();
Console.Write("Enter Phone: ");
string Phone=Console.ReadLine();
phoneBook.Add(Name,Phone);
break;
}
case 2:
{
Console.Write("Enter Name you want to search for: ");
string search=Console.ReadLine();
if(phoneBook.ContainsKey(search))
{
	Console.WriteLine($"{search} : {phoneBook[search]}");
}
else
{
	Console.WriteLine("Malik Number nahi hai");
}
break;
}
case 3:
{
string check=Console.ReadLine();
if(phoneBook.ContainsKey(check))
{
	string update=Console.ReadLine();
	phoneBook[check]=update;
}
else
{
Console.WriteLine("Malik ye number lena aapke Aukaat k bahar hai");
}
break;
}
case 4:
{
string delete=Console.ReadLine();
if(phoneBook.ContainsKey(delete))
{
if(phoneBook.Remove(delete))
{
Console.WriteLine("Uda diya malik");
}
}
else
{
Console.WriteLine("Malik ye number lena aapke Aukaat k bahar hai");
}
break;
}
case 5:
{
return;
}
default:
Console.WriteLine("Doabara prayas krre");
break;
}
        }
    }
}