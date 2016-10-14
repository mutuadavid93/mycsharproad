using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Instances of the Customer class
            Customer c1 = new Customer(){
                ID = 120,
                Name = "David Mutua"
            };

            Customer c2 = new Customer()
            {
                ID = 100,
                Name = "Street Money"
            };

            //Now Create the Dictionary
            Dictionary<int, Customer> dictCustomers = new Dictionary<int,Customer>();

            //Add customers to the Dictionary
            dictCustomers.Add(c1.ID, c1);
            dictCustomers.Add(c2.ID, c2);

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

                Console.WriteLine("Customer ID = {0} && Name = {1}", cust.ID, cust.Name);
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
    }
}
