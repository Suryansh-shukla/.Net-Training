using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CSharpNewFeatures
{
   public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
    }
    class DictionaryInitializer
    {
         static void Main(string[] args)
        {
            //List<Student> studList = new List<Student>();
            //studList.Add(new Student() { RollNo = 1, Name = "Alok" });
            //studList.Add(new Student() { RollNo = 2, Name = "Riya" });
            //studList.Add(new Student() { RollNo = 3, Name = "Rajat" });
            //studList.Add(new Student() { RollNo = 4, Name = "Nehal" });

            List<Student> studList = new List<Student>()//Collection Init
            {
                new Student() { RollNo = 1, Name = "Alok" },
                new Student() { RollNo = 2, Name = "Riya" },
                new Student() { RollNo = 3, Name = "Raman" },
                new Student() { RollNo = 4, Name = "Jiya" },

            };
           

            Dictionary <string,string> dictionaryObj = new Dictionary<string, string> ()             /* The new and friendly syntax */
            {
                ["Name"] = "Fizzy",
                ["Planet"] = "Kepler-452b",
                ["TN"]="TamilNadu",
                ["IN"]="India"
            };

            //Old Syntax
            Dictionary<string, string> demoObj = new Dictionary<string, string>()
            {
                {"101","Alok" },
                {"102","Riya" },
                {"103","Raman" }               

            };

            foreach (KeyValuePair<string, string> keyValuePair in dictionaryObj)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Write(keyValuePair.Key + ": ");
                Console.ForegroundColor = ConsoleColor.Green;
                Write(keyValuePair.Value + "\n");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Student s1 = new Student();

           // s1.ShowStudentDetails()
            ReadLine();
        }

    }
}
