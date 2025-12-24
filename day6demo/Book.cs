namespace day6demo;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Num_Pages { get; set; }
    public DateTime dueDate { get; set; }
    public DateTime returnedDate { get; set; }
    public Book()
    {
        Title = "Unknown";
        Author = "Unknown";
        Num_Pages = 0;
        dueDate = DateTime.Now.AddDays(14); // Default due date is 2 weeks from now
        returnedDate = DateTime.MinValue; // Indicates not yet returned
    }
    public Book(string title, string author, int num_pages,DateTime dueDate, DateTime returnedDate)
    {
        Title = title;
        Author = author;
        Num_Pages = num_pages;
        this.dueDate = dueDate;
        this.returnedDate = returnedDate;
    }
    
    public double AveragePagesReadPerDay(int daystoRead)
    {
        if (daystoRead <= 0)
        {
            throw new ArgumentException("Days to read must be greater than zero.");
        }
        return (double)Num_Pages / daystoRead;
    }
    public double CalculateLateFee(double dailyLateFeeRate)
    {
        if (returnedDate == DateTime.MinValue)
        {
            throw new InvalidOperationException("Book has not been returned yet.");
        }
        if (returnedDate <= dueDate)
        {
            return 0.0; // No late fee
        }
        TimeSpan lateDuration = returnedDate - dueDate;
        int lateDays = lateDuration.Days;
        return lateDays * dailyLateFeeRate;
    }
}
