using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpIndexers
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

    }

    public class Company
    {
        private List<Employee> listEmployees;

        public Company()
        {
            //Initialize the List
            listEmployees = new List<Employee>();

            //Add data to List
            listEmployees.Add(new Employee { EmployeeId = 10, Name = "David Mutua", Gender = "Male" });
            listEmployees.Add(new Employee { EmployeeId = 11, Name = "Mary Kanini", Gender = "Female" });
            listEmployees.Add(new Employee { EmployeeId = 12, Name = "Oscar Ngoya", Gender = "Male" });
        }

        //Create Indexers
        public string this[int employeeId]
        {
            //Use some LINQ
            get
            {
                //Find an Employee emp such that, 
                //emp.employeeId should match with whatever we are passing
                //into this Indexer.
                return listEmployees.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name;
            }
            set
            {
                //Now set their Name with what we
                //passed in indexer
                listEmployees.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name = value;
            }
        }

        //Overload Indexers
        //With Type or Number of Parameters
        public string this[string gender]
        {
            get
            {
                //Use a LINQ function called Count()
                //Example: if we pass Male in the Indexer,
                //Count all employees with Male Gender
                //And return the Total.

                //Then convert the int to string
                return listEmployees.Count(emp => emp.Gender == gender).ToString();
            }
            set
            {
                foreach (Employee employee in listEmployees)
                {
                    if (employee.Gender == gender)
                    {
                        //NB: value is whatever you will pass
                        //during assignment on the Indexer.
                        employee.Gender = value;
                    }
                }
            }
        }
    }
}