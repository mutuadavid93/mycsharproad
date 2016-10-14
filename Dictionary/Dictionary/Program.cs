using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Instances of the Customer class
            Customer c1 = new Customer(){
                ID = 120,
                Name = "David Mutua",
                Salary=  4000
            };

            Customer c2 = new Customer()
            {
                ID = 100,
                Name = "Street Money",
                Salary = 10000
            };

            //Now Create the Dictionary
            Dictionary<int, Customer> dictCustomers = new Dictionary<int,Customer>();

            //Add customers to the Dictionary
            dictCustomers.Add(c1.ID, c1);
            dictCustomers.Add(c2.ID, c2);


            //Get the total elements in a Dictionary
            Console.WriteLine("This Dictionary has : {0} Elements ", dictCustomers.Count());
            Console.WriteLine(" ");

            //Overload Count(predicate).
            // A way of filtering elements.
            Console.WriteLine("Customers with Salary below 9000 : {0} ", dictCustomers.Count(kvp => kvp.Value.Salary < 9000 ));
            Console.WriteLine(" ");

            //This is Just a FUN Line
            Console.WriteLine(" DICTIONARY VALUES:");
            Console.WriteLine("---------------------------------------------------");

            //Loop to get the Dictionary Content
            //Alter: 
            //foreach (Customer cust in dictCustomers.Values)
            foreach (KeyValuePair<int, Customer> customer in dictCustomers)
            {
                Console.WriteLine("|| Key : {0} ||", customer.Key);

                //Use the Key to get Values
                Customer cust = customer.Value;

                Console.WriteLine("Customer ID = {0} && Name = {1} && Salary = {2}", cust.ID, cust.Name, cust.Salary);
                Console.WriteLine(" ");
                Console.WriteLine("---------------------------------------------------");
            }

        }
    }

    public class Customer
    {
        //Initialize Default properties
        public string Name { get; set; }
        public int ID { get; set; }
        public int Salary { get; set; }
    }
}
