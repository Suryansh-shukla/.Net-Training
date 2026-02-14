using System;
using System.Linq;
public class WordFrequencyCounter
{
	public static void Main()
	{	
		string Word=Console.ReadLine();
		string[] words=Word.ToString().Split();
		int count=0;
		foreach(var item in words)
		{
			count++;
			Console.WriteLine(item);
		}
		Console.WriteLine($"Total Words Count: {count}");
	}
}