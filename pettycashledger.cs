using System;
using System.Collections.Generic;

namespace PettyCashLedger
{
    class Program
    {
        static void Main(string[] args)
        {
            // Income Ledger
            Ledger<IncomeTransaction> incomeLedger = new Ledger<IncomeTransaction>();

            incomeLedger.AddEntry(new IncomeTransaction
            {
                Id = 1,
                Date = DateTime.Now,
                Amount = 500,
                Source = "Main Cash",
                Description = "Petty cash replenishment"
            });

            // Expense Ledger
            Ledger<ExpenseTransaction> expenseLedger = new Ledger<ExpenseTransaction>();

            expenseLedger.AddEntry(new ExpenseTransaction
            {
                Id = 101,
                Date = DateTime.Now,
                Amount = 20,
                Category = "Stationery",
                Description = "Pens and notebooks"
            });

            expenseLedger.AddEntry(new ExpenseTransaction
            {
                Id = 102,
                Date = DateTime.Now,
                Amount = 15,
                Category = "Food",
                Description = "Team snacks"
            });

            // Totals
            double totalIncome = incomeLedger.CalculateTotal();
            double totalExpense = expenseLedger.CalculateTotal();
            double balance = totalIncome - totalExpense;

            Console.WriteLine("===== PETTY CASH LEDGER =====\n");

            Console.WriteLine("Income Transactions:");
            DisplayTransactions(incomeLedger.GetAllTransactions());

            Console.WriteLine("\nExpense Transactions:");
            DisplayTransactions(expenseLedger.GetAllTransactions());

            Console.WriteLine("\n----------------------------");
            Console.WriteLine($"Total Income  : ₹{totalIncome}");
            Console.WriteLine($"Total Expense : ₹{totalExpense}");
            Console.WriteLine($"Net Balance   : ₹{balance}");
            Console.WriteLine("----------------------------");

            Console.ReadLine();
        }

        static void DisplayTransactions(List<Transaction> transactions)
        {
            foreach (var txn in transactions)
            {
                Console.WriteLine(txn.GetSummary());
            }
        }
    }
}
