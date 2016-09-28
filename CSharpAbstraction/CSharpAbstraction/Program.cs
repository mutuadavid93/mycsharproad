using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAbstraction
{
    /******************************
     * 
     *  ABSTRACTION C#
     * 
     * ***************************/

    //Declare an abstract class and a member
    public abstract class Teacher
    {
        public abstract void teacherName();
    }

    //Inherit the abstract class
    public class Student : Teacher
    {
        public override void teacherName()
        {
            Console.WriteLine("Print the abstract class's teacherName method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Instatiate and invoke
            Teacher teacher = new Student();
            teacher.teacherName();
        }
    }
}
