using System;
using System.Collections.Generic;
class LibraryManager
{
    private Dictionary<string, long> memberMap = new Dictionary<string, long>();
    public Dictionary<string, int> imposed = new Dictionary<string, int>();
    public Dictionary<string, int> payed = new Dictionary<string, int>();
    public int addMember(string memberId)
    {
        // WRITE YOUR CODE HERE
        if (memberMap.ContainsKey(memberId))
        {
            return 0;
        }
        else
        {
            long fine = 0;
            memberMap.Add(memberId, fine);
            imposed.Add(memberId, 0);
            payed.Add(memberId, 0);
            return 1;
        }
    }
    public int imposeFine(string memberId, long amount)
    {
        // WRITE YOUR CODE HERE
        if (memberMap.ContainsKey(memberId))
        {
            memberMap[memberId] += amount;
            imposed[memberId] += Convert.ToInt32(amount);
            return (int)memberMap[memberId];
        }
        return 0;
    }
    public int payFine(string memberId, long amount)
    {
        // WRITE YOUR CODE HERE
        if (memberMap.ContainsKey(memberId))
        {
            if (memberMap[memberId] > 0)
            {
                long actualpayment=Math.Min(amount, memberMap[memberId]);
                memberMap[memberId] -= actualpayment;
                payed[memberId] += Convert.ToInt32(actualpayment);
                    return (int)memberMap[memberId];
            }
        }
        return 0;
    }

    public string getDetails(string memberId)
    {
        // WRITE YOUR CODE HERE
        if (memberMap.ContainsKey(memberId))
        {
            return $"{ memberId}{ memberMap[memberId]}{ imposed[memberId]}{ payed[memberId]}";
        }
        return "Member Not Found";
    }
    public int processCommands(int N)
    {
        // WRITE YOUR CODE HERE
        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            if (input[0] == "ADD")
            {
                int addmember = addMember(input[1]);
            }
            else if (input[0] == "IMPOSE")
            {
                int imposedfine = imposeFine(input[1], long.Parse(input[2]));
            }
            else if (input[0] == "PAY")
            {
                int payedfine = payFine(input[1], long.Parse(input[2]));
            }
            else if (input[0] == "DETAILS")
            {
                Console.WriteLine(getDetails(input[1]));
            }
        }
        return 0;
    }
}
class Program
{
    static void Main(string[] args)
    {
        LibraryManager manager = new LibraryManager();
        // WRITE YOUR CODE HERE
        int n = Convert.ToInt32(Console.ReadLine());
        manager.processCommands(n);
    }
}
