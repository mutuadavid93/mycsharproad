using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPolymorphism
{
    /*********************************************
     * 
     *  POLYMORPHISM & VIRTUAL METHOD OVERRRIDING
     * 
     * ******************************************/

    //baseClass declarartion
    public class Employee
    {
        //declare fields public for childClass accessibility
        public string firstName = "David";
        public string lastName = "Mutua";

        //Method to be Overriden
        public virtual void printFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    //childClass One declaration
    public class fullTimeEmployee : Employee
    {
        //Overriding method
        public override void printFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " -- Full Time Employee");
        }
    }

    //childClass Two declaration
    public class partTimeEmployee : Employee
    {
        //Overriding method
        public override void printFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " -- Part Time Employee");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Invoke derived class method using baseClass reference variable
            Employee ftemp = new fullTimeEmployee();
            ftemp.printFullName();

            //Invoke a second derived class method
            Employee ptemp = new partTimeEmployee();
            ptemp.firstName = "William";
            ptemp.lastName = "Muli";
            ptemp.printFullName();
        }
    }
}
