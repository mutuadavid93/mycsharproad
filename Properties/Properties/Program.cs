using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{

    public class Student
    {
        private string name;
        private int _id;
        private int passmark = 40;

        //Use setter and getter methods to have control on
        //what is assigned to the properties
        //after using private access modifier

        public void SetId(int id)
        {

            if (id <= 0)
            {
                throw new Exception("Student ID cannot be Negative");
            }
            else { this._id = id; }            
        }

        public int GetId()
        {
            return this._id;
        }


        //set the name
        public void SetName(string Names)
        {
            if (string.IsNullOrEmpty(Names))
            {
                throw new Exception("Name cannot be null nor empty");
            }
            this.name = Names;
        }

        //get the name
        public string GetName()
        {
            return string.IsNullOrEmpty(this.name) ? "No name" : this.name;
        }

        //Make the passmark to be Read Only
        public int GetPassmark()
        {
            return this.passmark;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Invoke
            Student std = new Student();
            std.SetId(10);

            std.SetName("Makali");

            //Print the id
            Console.WriteLine("STudent ID = {0} ", std.GetId());

            //print Name
            Console.WriteLine("STudent Name = {0} ", std.GetName());

            //print the passmark
            Console.WriteLine("Passmark = {0} ", std.GetPassmark());
        }
    }
}
