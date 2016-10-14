using System;
using System.Collections.Generic;
using System.Linq;

namespace ConvertDictionary
{
    class Program
    {
        /**************************
         * 
         *  DICTIONARY CONVERSION
         * 
         * ***********************/
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

            //First Using arrays
            Employee[] employeeArray = new Employee[3];

            //Add Employee Objects to array
            employeeArray[0] = emp1;
            employeeArray[1] = emp2;
            employeeArray[2] = emp3;

            //Convert Array to a Dictionary
            Dictionary<int, Employee> employeeDict = employeeArray.ToDictionary(emp => emp.ID, emp => emp);

            //Loop through the Dictionary
            foreach (KeyValuePair<int, Employee> kvp in employeeDict)
            {
                //Print the Key
                Console.WriteLine("|| Key: {0} ||", kvp.Key);
                Console.WriteLine("");

                //Print the Content
                Employee employee = kvp.Value;
                Console.WriteLine("Employee Name : {0} && Salary : {1}", employee.fullName, employee.salary);
                Console.WriteLine("--------------------------------------");
            }

        }
    }

    public class Employee
    {
        public int ID { get; set; }
        public int salary { get; set; }
        public string fullName { get; set; }
    }
}
