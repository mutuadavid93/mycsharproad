using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    /*********************************
     * 
     *      STRUCTURES IN C#.
     *      @check Notes_005.txt for 
     *      defferences
     * 
     * *****************************/

    //Declare structs with the struct keyword
    public struct Student
    {
        private string _school;
        private int _meangrade;

        //Encapsulate using "School" property
        public string School
        {
            get { return this._school; }
            set { this._school = value; }
        }

        //Encapsulate using "Meangrade" property
        public int Meangrade
        {
            get { return this._meangrade; }
            set { this._meangrade = value; }
        }


        //Methods
        public void printInfo()
        {
            Console.WriteLine("School: {0}, Meangrade: {1}", this._school, this._meangrade);
        }

    class Program
    {
        }
        static void Main(string[] args)
        {
            //instatiate and invoke
            Student std = new Student { 

                //initialize using props. C# 3.0
                School = "Makadara Academy",
                Meangrade = 340

            };
            std.printInfo();
        }
    }
}
