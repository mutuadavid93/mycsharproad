using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfaces
{
    /******************************
     * 
     *      INTERFACES C#
     *      Notes_006.txt
     * 
     * ****************************/

    //Declare an Interface
    interface ITeacher
    {
        void printTeacherName();
    }

    //A class inherit the interface
    public class Student : ITeacher
    {

        //Implement the Interface Members
        public void printTeacherName()
        {
            Console.WriteLine("printTeacherName method impemented");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate and Invoke Method
            ITeacher teachername = new Student();
            teachername.printTeacherName();
        }
    }
}
