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

    interface IHeadTeacher
    {
        void printTeacherName();
    }

    //A class inherit the interface(s)
    public class Student : ITeacher, IHeadTeacher
    {

        //Implement the Interface Members.
        //By implementing the member normally,
        //you make Teacher interface default.
        public void printTeacherName()
        {
            Console.WriteLine("ITeacher interface method impemented");
        }

        //Explicitly implement the IHeadTeacher interface
        void IHeadTeacher.printTeacherName()
        {
            Console.WriteLine("IHeadTeacher interface method implemented");
        }
    }

    /******************************
     * 
     *      EXPLICIT INTERFACE 
     *      IMPLEMENTATION
     * 
     * **************************/



    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate and Invoke Method
            ITeacher teachername = new Student();
            teachername.printTeacherName();

            //Explicit invokation, by Typecasting
            Student student = new Student();
            ((IHeadTeacher)student).printTeacherName();
        }
    }
}
