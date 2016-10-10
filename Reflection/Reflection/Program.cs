using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type T = Type.GetType("Reflection.Customer");

            Type T = typeof(Customer);

            //get the properties
            PropertyInfo[] properties = T.GetProperties();

            Console.WriteLine("Customer class properties: ");
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType +" "+property.Name);
            }

            Console.WriteLine();

            //get methods
            MethodInfo[] methods = T.GetMethods();
            Console.WriteLine("Customer class Methods: ");
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }
        }
    }

    public class Customer
    {
        public int ID {get; set;}
        public string fullName { get; set; }
        public string product { get; set; }

        public Customer(int id, string fName) 
        {
            this.ID = id;
            this.fullName = fName;
        }
    }
}
