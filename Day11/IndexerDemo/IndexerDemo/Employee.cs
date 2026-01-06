using System;
using System.Collections.Generic;
using System.Text;

namespace IndexerDemo
{
    class Employee
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
    }
}
