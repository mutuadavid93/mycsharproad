using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.printFullName();

            Customer c2 = new Customer(23, 78000);
            c2.printSalaryAge();

            //Instantiate this class and invoke the behaviour
            Customer customer = new Customer("David", "Mutua");
            customer.printFullName();
        }
    }

    //Create a Customer class
    class Customer
    {

        //Class state/data/fields
        string _fname;
        string _lname;

        int age;
        int salary;

        //initialize the fields with default values using a default constructor
        public Customer(): this("No firstName", "No lastName") {  }

        //Initialize the fields using a constructor
        public Customer(string FirstName, string LastName)
        {
            this._fname = FirstName;
            this._lname = LastName;
        }

        //Constructor overloading
        public Customer(int age, int salary)
        {
            this.age = age;
            this.salary = salary;
        }

        //Class Behaviour/Method/Function one
        public void printFullName()
        {
            Console.WriteLine("Welcome {0} {1} ", this._fname, this._lname);
        }

        //Class Behaviour/Method/Function two
        public void printSalaryAge()
        {
            Console.WriteLine("Age {0}, and earning: {1}", this.age, this.salary);
        }
    }
}
