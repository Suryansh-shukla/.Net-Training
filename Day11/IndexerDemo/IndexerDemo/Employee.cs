using System;
using System.Collections.Generic;
using System.Text;

namespace IndexerDemo
{
    internal class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public int BSalary { get; set; }
        public static Employee operator +(Employee emp1, Employee emp2)
        {
            Employee empObj = new Employee();
            empObj.BSalary = emp1.BSalary + emp2.BSalary;
            return empObj;
        }

        public static Employee operator +(Employee emp1, Employee emp2)
        {
            return new Employee
            {
                BSalary = (emp1?.BSalary ?? 0) + (emp2?.BSalary ?? 0)
            };
        }
    }
}
