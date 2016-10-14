using System;
using System.Collections.Generic;
using System.Reflection;

namespace LateBinding
{
    /***********************
     * 
     *     LATE BINDING
     * 
     * ********************/
    class Program
    {
        static void Main(string[] args)
        {
            //Load the executing assembly
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            //Get Types within that assembly
            Type customerType = executingAssembly.GetType("LateBinding.Customer");

            //Instatiate the Type (class)
            object customerInstance = Activator.CreateInstance(customerType);

            //Get the method's info we want to execute
            MethodInfo getFullNameMethod = customerType.GetMethod("getFullName");

            //Create an array of the Parameters to pass in the Method
            string[] parameters = new string[2];
            parameters[0] = "David";
            parameters[1] = "Mutua";

            //Invoke the method. You have to Typecast the object to string.
            //Then print customer's full name
            string fullName = (string)getFullNameMethod.Invoke(customerInstance, parameters);
            Console.WriteLine("Customer full name = {0}", fullName);
        }
    }

    //IMAGINE THIS CLASS MUST EXIST!!!
    public class Customer
    {
        public string getFullName(string fName, string lName)
        {
            return fName + " " + lName;
        }
    }
}
