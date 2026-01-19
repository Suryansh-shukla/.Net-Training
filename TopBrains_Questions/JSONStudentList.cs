using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
public record Student(string Name, int Score);
public class StudentFilterRequest
{
    public string[] Items { get; set; }=Array.Empty<string>();
    public int MinScore { get; set; }
}
class Program
{
    public static void Main()
    {
        StudentFilterRequest request =new StudentFilterRequest
        {
            Items = new string[] { "Alice:85", "Bob:90", "Charlie:78", "David:92" },
            MinScore = 80
        };
        string json=BuildStudentJson(request);
        Console.WriteLine(json);   
    }
    static string BuildStudentJson(StudentFilterRequest request)
    {
        if(request.Items==null || request.Items.Length==0)
        {
            return "[]";
        }
        List<Student> students=new(request.Items.Length);
        foreach(string item in request.Items)
        {
            int colonIndex=item.IndexOf(':');
            if(colonIndex>0 && colonIndex<item.Length-1)
            {
                string name=item.Substring(0,colonIndex);
                if(int.TryParse(item.Substring(colonIndex+1),out int score))
                {
                    if(score>=request.MinScore)
                    {
                        students.Add(new Student(name,score));
                    }
                }
            }
            
        }
        var filteredStudents=students.OrderByDescending(s=>s.Score).ThenBy(s=>s.Name);
        return JsonSerializer.Serialize(filteredStudents);
    }
}