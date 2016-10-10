using System;

namespace AccessModifiers
{
    /*********************
     * 
     *  C# ACCESS MODIFIERS
     * 
     * *******************/

    public class Customer
    {
        private int _id;
        
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        protected int nationalID;
    }

    public class RetailCustomer : Customer
    {
        public void printID() {
            base.nationalID = 50;
            Console.WriteLine(this.nationalID);
        }

        public static void Main(string [] args)
        {
            RetailCustomer rcust = new RetailCustomer();
            rcust.printID();
        }
    }
}
