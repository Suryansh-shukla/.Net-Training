using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> cityRoute = new Dictionary<string, string>
        {
            { "Pune", "R1" },
            { "Mumbai", "R2" },
            { "Nashik", "R1" }
        };

        // TODO: Invert and print route-wise cities
	Dictionary<string,List<string>> routecity=new Dictionary<string,List<string>>();
	foreach(var item in cityRoute)
	{
		if(!routecity.ContainsKey(item.Value))
		{
			routecity[item.Value]=new List<string>();
		}
		routecity[item.Value].Add(item.Key);
	}
	foreach(var item in routecity)
	{
		Console.WriteLine($"{item.Key} : {string.Join(",",item.Value)}");
	}
    }
}