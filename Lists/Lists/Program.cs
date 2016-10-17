using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;

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

            //Now sort This List
            employeeList.Sort();

            //After sorting
            Console.WriteLine("SORTING BY SALARY: ");
            foreach (Employee empSorted in employeeList)
            {
                Console.WriteLine(empSorted.salary);
            }
            Console.WriteLine();

            //Get the Position of an element
            //in the List
            Console.WriteLine("Emp3 is at index : {0}", employeeList.IndexOf(emp3, 2));
            Console.WriteLine();

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

            //Now Instantiate the SortBy() and 
            //pass its instance to Sort() 
            //To sort the List by fullName.
            Console.WriteLine("SORTING BY FULLNAME:");

            SortByName sortbyname = new SortByName();
            employeeList.Sort(sortbyname);

            foreach (Employee empSorted in employeeList)
            {
                Console.WriteLine(empSorted.fullName);
            }
            Console.WriteLine();

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
            
            //Now pass the delegate literal into the Sort()
            //employeeList.Sort(delegate(Employee empA, Employee empB) { return empA.ID.CompareTo(empB.ID); });

            //Alternatively use a Lambda Expression inside the Sort()
            employeeList.Sort((x, y) => x.ID.CompareTo(y.ID));

            Console.WriteLine("SORTING BY ID USING DELEGATES");
            foreach (Employee employeeDelegate in employeeList)
            {
                Console.WriteLine(employeeDelegate.ID);
            }
            Console.WriteLine();

            //Make a List ReadOnly
            ReadOnlyCollection<Employee> readOnlyEmpList = employeeList.AsReadOnly();

        }// End class Program


        //SORTING WHEN WE DON'T OWN THE LOGIC CLASS
        //Instead we create our own class.
        public class SortByName : IComparer<Employee>
        {
            public int Compare(Employee x, Employee y)
            {
                return x.fullName.CompareTo(y.fullName);
            }
        }


        public class Employee : IComparable<Employee>
        {
            public int ID { get; set; }
            public string fullName { get; set; }
            public int salary { get; set; }


            //Now Implement IComparable Interface Method
            //To help compare complex types.
            public int CompareTo(Employee other)
            {
                //NB: "this" Means the Current Instance(List item)
                //of the Object of type Employee.
                return this.salary.CompareTo(other.salary);
            }
        }
    }
}
