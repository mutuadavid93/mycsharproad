using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleClassInheritance
{
    /************************
     * 
     *  Uses Interfaces
     * 
     * **********************/

    //Create an Interface and a class to inherit it
    interface IHeadTeacher
    {
        void printHeadTeacherInfo();
    }
    public class Teacher : IHeadTeacher
    {
        //implement IHeadTeacher method
        public void printHeadTeacherInfo()
        {
            Console.WriteLine("Mr Murathi is the Headteacher of Wango Sec School");
        }
    }


    //Another Interface and class
    interface IStudent
    {
        void printStudentName();
    }
    public class Books : IStudent
    {
        public void printStudentName()
        {
            Console.WriteLine("David mutua is a student at Wango AIC");
        }
    }

    //Now a method Inheriting Books and Teacher classes via interfaces
    //IHeadTeacher and IStudent
    public class ComboBooksTeacher : IHeadTeacher, IStudent
    {
        //no need to re-implement the methods
        //so we just do this
        Teacher teach = new Teacher();
        Books book = new Books();

        public void printHeadTeacherInfo()
        {
            teach.printHeadTeacherInfo();
        }

        public void printStudentName()
        {
            book.printStudentName();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            //Instatiate and invoke
            ComboBooksTeacher combo = new ComboBooksTeacher();

            combo.printHeadTeacherInfo();
            combo.printStudentName();
        }
    }
}
