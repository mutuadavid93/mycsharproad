using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the Objects
            Employee emp1 = new Employee()
            {
                ID = 200,
                salary = 20000,
                fullName = "Mark Onyach"
            };

            Employee emp2 = new Employee()
            {
                ID = 201,
                salary = 10000,
                fullName = "Hillary Ngetich"
            };

            Employee emp3 = new Employee()
            {
                ID = 203,
                salary = 39000,
                fullName = "Etyan Kizito"
            };

            //Create the Collection i.e List
            List<Employee> employeeList = new List<Employee>(2);

            //Add the Object instances into List
            employeeList.Add(emp1);
            employeeList.Add(emp2);
            employeeList.Add(emp3);

            //Get the Position of an element
            //in the List
            Console.WriteLine(employeeList.IndexOf(emp3, 2));

            //Check whether an item exists in a list
            if (employeeList.Contains(emp3))
            {
                Console.WriteLine("Yes this List contains emp3 item!!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Employee 3 doesn't exist in the List");
            }

            //Search for the FIRST Employee with a Salary
            //Less than 20000
            Employee employed = employeeList.Find(emp => emp.salary < 20000);

            Console.WriteLine("Employee with less than 20000 salary is :");
            Console.WriteLine("{0} earning {1}", employed.fullName, employed.salary);
            Console.WriteLine("");

            //Search and retrun ALL the Employees
            //with more than 10000 salary
            List<Employee> allEmps = employeeList.FindAll(employ => employ.salary > 10000);

            //Loop to get Results after search
            Console.WriteLine("All employees with more than 10000 salary are :");
            Console.WriteLine("");
            foreach (Employee anEmployee in allEmps)
            {
                Console.WriteLine("{0} earning {1}", anEmployee.fullName, anEmployee.salary);
                Console.WriteLine("====================================");
            }
            Console.WriteLine("");


            //Loop to get list content
            Console.WriteLine("All Employees in the List:");
            foreach (Employee employee in employeeList)
            {
                Console.WriteLine("Name : {0} && Salary : {1}", employee.fullName, employee.salary);
                Console.WriteLine("-------------------------------------------------");
            }
        }

        public class Employee
        {
            public int ID { get; set; }
            public string fullName { get; set; }
            public int salary { get; set; }
        }
    }
}
