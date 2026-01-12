using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Console_App
{
    class Program
    {
        public static void LinqToObjectDemo()
        {
            int[] numArray = { 10, 2, 12, 34, 45, 65, 23, 66, 48, 8, 88, 27 };
            string[] nameArray = { "Alok", "Rajat", "Sunil", "Priya", "Ayush", "Harshita", "Suryansh", "Himanshu", "Mahi", "Naina", "Bachu", "Chotu", "Mahesh" };
            //Normal Case
            //foreach (var item in numArray)
            //{
            //    if(item% 2 == 0)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //LINQ Case
            var result= from data in numArray
                        where data % 2 == 0
                        select data;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Enter name to Search : ");
            string dataToSearch = Console.ReadLine();
            var resultname=from data in nameArray
                           orderby data
                       select data;
            var resultname1=from data in nameArray
                       where data==dataToSearch
                       select data;
            foreach (var item in resultname)
            {
                Console.WriteLine(item); 
            }
            foreach (var item in resultname1)
            {
                Console.WriteLine(item); 
            }
            var resultname2=nameArray.Where(data=>data== dataToSearch);

        }
        public static void LinqToObjectDemoOnCustomType()
        {
            List<Customer> custList = new List<Customer>()
            {
                new Customer(){CustomerId=101,CustomerName="Alok",City="Pune"},
                new Customer(){CustomerId=102,CustomerName="Rajat",City="Mumbai"},
                new Customer(){CustomerId=103,CustomerName="Sunil",City="Pune"},
                new Customer(){CustomerId=104,CustomerName="Priya",City="Chennai"},
                new Customer(){CustomerId=105,CustomerName="Ayush",City="Delhi"},
                new Customer(){CustomerId=106,CustomerName="Amit",City="Pune"},
                new Customer(){CustomerId=107,CustomerName="Karan",City="Mumbai"},
                new Customer(){CustomerId=108,CustomerName="Rohit",City="Pune"},
                new Customer(){CustomerId=109,CustomerName="Neha",City="Chennai"},
                new Customer(){CustomerId=110,CustomerName="Vikas",City="Delhi"},
                new Customer(){CustomerId=111,CustomerName="Sandeep",City="Pune"},
                new Customer(){CustomerId=112,CustomerName="Suryansh",City="Mumbai"},
                new Customer(){CustomerId=113,CustomerName="Ankit",City="Pune"},
                new Customer(){CustomerId=114,CustomerName="Pooja",City="Chennai"},
                new Customer(){CustomerId=115,CustomerName="Rahul",City="Delhi"},
            };
            var data = new
            {
                OrderID = 1100,
                OrderDate = "12/01/2026",
                TotalAmount = 14000
            };
            var result = custList.Where(cust => cust.City == "Mumbai");
            var result1 = custList.FindAll(cust => cust.City == "Delhi");
            foreach (var item in result1)
            {
                Console.WriteLine($"{item}");
            }
            foreach (var item in result)
            {
                Console.WriteLine($"{item.CustomerId}\t{item.CustomerName}\t{item.City}");
            }
        }
        //public static void LambdaLookUp()
        //{
        //    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //    var query = numbers.ToLookup(i % 2 == 0);
        //    foreach (IGrouping<int, int> group in query)
        //    {
        //        Console.WriteLine("Key :{0}", group.Key);
        //        foreach (int number in group)
        //        {
        //            Console.WriteLine(number);
        //        }
        //    }

        //}
        public static void LambdaLookUp()
        {
            StudentRepo sRepo=new StudentRepo();
            List<Student> tempList = sRepo.GetAllStudents();
            var query = tempList.ToLookup(s=>s.Gender=="Male");
            foreach (IGrouping<bool, Student> group in query)
            {
                //Console.WriteLine("Key :{0}", group.Key);
                int totFees = 0;
                if (group.Key == true)
                {
                    Console.WriteLine("Male Student Details Below");
                }
                else
                {
                    Console.WriteLine("Female Student Details Below");
                }
                foreach (Student std in group)
                {
                    Console.WriteLine($"{std.Name}");
                    totFees+=std.Fees;
                }
                Console.WriteLine("Total Fee Paid :");
            }
            //var maleFeesPaid = tempList.ToLookup(s => s.Gender == "Male").Sum();

        }
        static void Main(string[] args)
        {
            //    LinqToObjectDemo();
            //    LinqToObjectDemoOnCustomType();
            //LambdaLookUp();
            StudentRepo sRepo=new StudentRepo();
            List<Student> tempList = sRepo.GetAllStudents();
            var total = tempList.Select(s => s.Fees).Sum();
            var totalMaleFees = tempList.Where(s => s.Gender == "Male").Select(s => s.Fees).Sum();
            Console.WriteLine("Total Fees Paid by all Students :"+ total);
            Console.WriteLine("Total Male Students Fees Paid:"+ totalMaleFees);
        }
    
    }
}
