using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OverrideEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defference btn the two string objects
            //Using System.StringBuilder instead of System.String
            StringBuilder userString = new StringBuilder("C#");
            userString.Append(" Programming");
            Console.WriteLine(userString.ToString());

            //A practical Example in a for loop
            StringBuilder myString = new StringBuilder();
            int x = 0;
            for (; x < 1000; )
            {
                myString.Append(x.ToString() + " ");
                x++;
            }
            Console.WriteLine(myString);

            Customer c1 = new Customer();
            c1.fName = "David";
            c1.lName = "Mutua";

            Customer c2 = new Customer();
            c2.fName = "David";
            c2.lName = "Mutua";

            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1.Equals(c2));
        }
    }

    public class Customer
    {
        //Initialize default properties
        public string fName { get; set; }
        public string lName { get; set; }

        //Now Override Equals()
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            //if object is not of type Customer
            if (!(obj is Customer))
            {
                return false;
            }

            //Nb: This is used when we are comparing during invokation
            //i.e c1.Equals(c2) 
            //c2.fName is same as ((Customer)obj).fName

            //Type Cast the Object
            //Then compare and return True or False
            return this.fName == ((Customer)obj).fName &&
                this.lName == ((Customer)obj).lName;
        }

        //Now Override GetHashCode of the two properties
        public override int GetHashCode()
        {
            return this.fName.GetHashCode() ^ this.lName.GetHashCode();
        }
    }
}
