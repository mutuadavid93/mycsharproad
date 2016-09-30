using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and add data to a list
            List<Student> studentList = new List<Student>();

            studentList.Add(new Student() { studentName = "David mutua", passMark = 40 });
            studentList.Add(new Student() { studentName = "Mark onyach", passMark = 70 });
            studentList.Add(new Student() { studentName = "Oganga yaa", passMark = 50 });

            //insrantiate the delegate
            IsProceeding proceeding = new IsProceeding(Proceed);

            //invoke the logicMethod
            Student.proceedToNextClass(studentList, proceeding);

        }

        //Delegate's method
        public static bool Proceed(Student student)
        {
            if (student.passMark >= 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    //Declare your delegate
    public delegate bool IsProceeding(Student student);

    //create our class and a static logicMethod()
    public class Student
    {
        //Default properties
        public int passMark;
        public string studentName{get; set;}

        public static void proceedToNextClass(List<Student> studentList, IsProceeding proceeding)
        {
            foreach (Student student in studentList)
            {
                if (proceeding(student))
                {
                    Console.WriteLine(student.studentName + " proceed to the next class");
                }
            }
        }
    }
}
