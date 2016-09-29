using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesWithLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the List
            List<Employee> employees = new List<Employee>();

            //Add the employee to lists
            //by setting the properties
            employees.Add(new Employee() { salary = 20000, empName = "Johnson Foo" });
            employees.Add(new Employee() { salary = 6000, empName = "Jane Doe" });

            //invoke the promoteEmp and pass the list
            Employee.promoteEmp(employees);
        }
    }

    public class Employee
    {
        //properties without logic
        public int salary { get; set; }
        public string empName { get; set; }


        //promote method
        public static void promoteEmp(List<Employee> emplist)
        {
            foreach (Employee emp in emplist)
            {
                if (emp.salary >= 10000)
                {
                    Console.WriteLine(emp.empName + " Promoted");
                }
            }
        }

    }
}
