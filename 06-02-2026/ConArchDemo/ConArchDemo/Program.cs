using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConArchDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StudentDAL sDal = new StudentDAL();
            List<Student> students = sDal.ShowAllStudents();
            foreach (var item in students)
            {
                Console.WriteLine($"{item.RollNo}\t{item.Name}\t{item.Address}\t{item.PhoneNo}");
            }
        }
    }
}
