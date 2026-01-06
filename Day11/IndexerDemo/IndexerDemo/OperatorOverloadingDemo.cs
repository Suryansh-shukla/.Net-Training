using System;
using System.Collections.Generic;
using System.Text;

namespace IndexerDemo
{
    class OperatorOverloadingDemo
    {
        
        static void Main(string[] args)
        {
            Employee emp1=new Employee() { EmpID=101,EmpName="Alok",BSalary=45000};
            Employee emp2=new Employee() { EmpID=102,EmpName="Rakshas",BSalary=55000};
            Employee emp3=new Employee() { EmpID=103,EmpName="Buddy",BSalary=60000};
            Employee empObj = emp1 + emp2 + emp3;
            System.Console.WriteLine($"Total Salary is: {empObj.BSalary}");
        }
    }
}
