using System;
using System.Collections.Generic;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate and Invoke
            Customer[] customers = new Customer[3];
            
            //add values into the array
            customers[0] = new Customer { Name = "Kathini", Gender = Gender.Female };
            customers[1] = new Customer { Name = "Mark", Gender = Gender.Male };
            customers[2] = new Customer { Name = "Sherlock", Gender = Gender.Unknown };

            //loop through the Object array
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Name = {0} && Gender = {1}", customer.Name, getGender(customer.Gender));
            }


            ///Get the Names and Values of the 
            ///Gender enum properties
            short[] values = (short[])Enum.GetValues(typeof(Gender));

            foreach (short value in values)
            {
                Console.WriteLine(value);
            }

            string[] names = Enum.GetNames(typeof(Gender));

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }

        //A static method outside the static main()
        public static string getGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Female:
                    return "Female";
                case Gender.Male:
                    return "Male";
                case Gender.Unknown:
                    return "Unknown";
                default:
                    return ("Invalid gender value");

            }
        }
    }

    //Try to use the enums
    public class Customer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }

    //Create the Enum
    //Of type Short
    public enum Gender : short
    {
        Male = 3, 
        Female = 5,
        Unknown
    }
}
