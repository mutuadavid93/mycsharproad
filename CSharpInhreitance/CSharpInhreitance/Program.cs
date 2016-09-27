using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInhreitance
{

    /*************************************
     * 
     *      INHERITANCE & METHOD HIDDING
     * 
     * **********************************/

    public class Employee
    {

        //make all attributes public for accessibility by children classes
        public string firstName;
        public string lastName;

        //default constructor
        public Employee()
        {
            Console.WriteLine("From a parent's default constructor");
        }

        //overload constructor
        public Employee(string message)
        {
            Console.WriteLine(message);
        }

        public void printFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    //child class
    public class fullTimeEmployee : Employee
    {
        public float YearlySalary;
    }

    //child class
    public class partTimeEmployee : Employee
    {
        public float HourlyRate;

        //control base class using a child constructor
        public partTimeEmployee()
            : base("Child class controlling parent class!!")
        {
            Console.WriteLine("Then print a child's details");
        }

        //Method hidding
        public new void printFullName()
        {
            //base.printFullName(); // unhide the method
            Console.WriteLine(firstName + " " + lastName+ " -- Contractor");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Initialize the fields
            partTimeEmployee pt = new partTimeEmployee();
            pt.firstName = "PartTime";
            pt.lastName = "Employee";

            //or unhide the method using type casting
            ((Employee)pt).printFullName();

            fullTimeEmployee ft = new fullTimeEmployee();
            ft.firstName = "FullTime";
            ft.lastName = "Employee";
            ft.printFullName();
        }
    }
}
