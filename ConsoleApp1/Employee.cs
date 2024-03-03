using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    public class CheckSalary : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.Salary > y.Salary)
            {
                return 1;
            }
            else if (x.Salary < y.Salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
    public class Program1
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee { Name = "Vishal", Salary = 45550 };
            Employee emp2 = new Employee { Name = "Rajesh", Salary = 55550 };

            CheckSalary c = new CheckSalary();

            int result = c.Compare(emp1, emp2);
            if (result == 1)
            {
                Console.WriteLine("Vishal has higher Salary than Rajesh ");
            }
            else if (result == -1)
            {
                Console.WriteLine("Rajesh has higher Salary than Vishal");
            }
            else
            {
                Console.WriteLine("Vishal And Rajesh has Equal salary");
            }
        }
    }
    
}
