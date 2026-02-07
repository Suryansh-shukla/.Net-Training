using System;
using System.Linq;
using System.Collections.Generic;
public class Transaction
{
    public int TenantId { get; set; }
    public string Type { get; set; }
    public decimal Amount { get; set; }
    public DateTime Timestamp { get; set; }
}
public class Program
{
    public static void Main(string[] args)
    {
        List<Transaction> transactions = new List<Transaction>
        {
            new Transaction { TenantId = 1, Type = "Credit", Amount = 100, Timestamp = DateTime.Now.AddMinutes(-10) },
            new Transaction { TenantId = 1, Type = "Debit", Amount = 50, Timestamp = DateTime.Now.AddMinutes(-9) },
            new Transaction { TenantId = 1, Type = "Credit", Amount = 200, Timestamp = DateTime.Now.AddMinutes(-8) },
            new Transaction { TenantId = 1, Type = "Debit", Amount = 30, Timestamp = DateTime.Now.AddMinutes(-7) },
            new Transaction { TenantId = 1, Type = "Credit", Amount = 150, Timestamp = DateTime.Now.AddMinutes(-6) },
            new Transaction { TenantId = 1, Type = "Debit", Amount = 20, Timestamp = DateTime.Now.AddMinutes(-5) },
            new Transaction { TenantId = 1, Type = "Credit", Amount = 300, Timestamp = DateTime.Now.AddMinutes(-4) },
            new Transaction { TenantId = 1, Type = "Debit", Amount = 10, Timestamp = DateTime.Now.AddMinutes(-3) },
            new Transaction { TenantId = 1, Type = "Credit", Amount = 250, Timestamp = DateTime.Now.AddMinutes(-2) },
            new Transaction { TenantId = 1, Type = "Debit", Amount = 40, Timestamp = DateTime.Now.AddMinutes(-1) }
        };
        var tenantTransactions = transactions.Where(t => t.TenantId == 1);
        var totalCredits = tenantTransactions.Where(t => t.Type == "Credit").Sum(t => t.Amount);
        var totalDebits = tenantTransactions.Where(t => t.Type == "Debit").Sum(t => t.Amount);
        var peakHour = tenantTransactions.GroupBy(t => t.Timestamp.Hour)
                                        .Select(g => new { Hour = g.Key, Count = g.Count() })
                                        .OrderByDescending(g => g.Count)
                                        .FirstOrDefault()?.Hour;
        var suspiciousTransactions = tenantTransactions.Where(t => t.Timestamp >= DateTime.Now.AddMinutes(-5))
                                                        .GroupBy(t => t.Timestamp)
                                                        .Where(g => g.Count() > 3)
                                                        .SelectMany(g => g);
        Console.WriteLine($"Total Credits: {totalCredits}");
        Console.WriteLine($"Total Debits: {totalDebits}");
        Console.WriteLine($"Peak Transaction Hour: {peakHour}");
        Console.WriteLine("Suspicious Transactions:");
        foreach (var transaction in suspiciousTransactions)
        {
            Console.WriteLine($"Type: {transaction.Type}, Amount: {transaction.Amount}, Timestamp: {transaction.Timestamp}");
        }

    }
}