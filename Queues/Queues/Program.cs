using System;
using System.Collections.Generic;
using System.Linq;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the Objects
            Student c1 = new Student() { ID = 100, Name = "David Mutua", Gender = "Male" };
            Student c2 = new Student() { ID = 200, Name = "Street Money", Gender = "Male" };
            Student c3 = new Student() { ID = 300, Name = "Mary Kathini", Gender = "Female" };

            //Now add the objects into a Queue
            Queue<Student> students = new Queue<Student>();

            students.Enqueue(c1);
            students.Enqueue(c2);
            students.Enqueue(c3);

            //Retrieve first item from the Queue
            //and retain it.
            Student stude = students.Peek();
            Console.WriteLine("The item at begging of queue : {0}", stude.Name);
            Console.WriteLine();

            //Retrieve first item from the Queue
            //and return it.
            Student studeent = students.Dequeue();
            Console.WriteLine("First item : {0} && Queue capacity : {1}", studeent.Name, students.Count);
            Console.WriteLine();

            //Now Loop and print the Queue content
            foreach (Student std in students)
            {
                Console.WriteLine("Name : {0} && Gender : {1}", std.Name, std.Gender);
                Console.WriteLine("---------------------------------------");
            }
        }
    }

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}
