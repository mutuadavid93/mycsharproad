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

            //Instantiate the delegate
            IsPromotable isEligibleToPromote = new IsPromotable(Promote);

            //Now invoke the promoteEmployee()
            Employee.promoteEmp(employees, isEligibleToPromote);
        }

        //Create the method with signature same to delegate's
        public static bool Promote(Employee emp)
        {
            if (emp.salary >= 10000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    public delegate bool IsPromotable(Employee emp);

    public class Employee
    {
        //properties without logic
        public int salary { get; set; }
        public string empName { get; set; }


        //promote method
        public static void promoteEmp(List<Employee> emplist, IsPromotable isEligibleToPromote)
        {
            foreach (Employee employee in emplist)
            {
                if (isEligibleToPromote(employee))
                {
                    Console.WriteLine(employee.empName + " Promoted");
                }
            }
        }

    }
}
