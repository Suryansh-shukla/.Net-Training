using System;
using System.Collections.Generic;
using System.Linq;

public class Movie
{
public string Title{get; set; }
public string Artist{get; set; }
public string Genre{get; set; }
public decimal Ratings{get; set; }

}
public class Program
{
public List<Movie> MovieList = new List<Movie>();
public void AddMovie(string movieDetails)
{
	string[] parts=movieDetails.Split(',');
	Movie m=new Movie
	{
		Title = parts[0].Trim(),
		Artist=parts[1].Trim(),
		Genre= parts[2].Trim(),
		Ratings=decimal.Parse(parts[3].Trim())
	};
	MovieList.Add(m);
}
public List<Movie> ViewMoviesByGenre(string genre)
{
	return MovieList.Where(x=>x.Genre.Equals(genre,StringComparison.OrdinalIgnoreCase)).ToList();
}
public List<Movie> ViewMoviesByRatings()
{
return MovieList.OrderBy(x=>x.Ratings).ToList();
}
public static void Main()
{
	Program p=new Program();
	Console.WriteLine("Enter the Number of Movie you want to Insert: ");
	int n= Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Enter the data in Title,Artist,Genre,Ratings Format");
	for(int i=0;i<n;i++)
	{
		string s=Console.ReadLine();
		p.AddMovie(s);
	}
	Console.WriteLine("Please! Enter the Genre you are looking for: ");
	string genre=Console.ReadLine();
	var bygenre=p.ViewMoviesByGenre(genre);
	if(bygenre.Count==0)
	{
		Console.WriteLine($"No Movies forund in genre {genre}");
	}
	else
	{
	foreach(var item in bygenre)
	{
		Console.WriteLine($"{item.Title} {item.Artist} {item.Genre} {item.Ratings}");
	}
	}
	var sortedratings=p.ViewMoviesByRatings();
	foreach(var item in sortedratings)
	{
		Console.WriteLine($"{item.Title} {item.Artist} {item.Genre} {item.Ratings}");
	}
}
}
