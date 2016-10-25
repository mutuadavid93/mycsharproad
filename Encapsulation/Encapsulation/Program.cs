using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Duck = new Animal();
            Duck.locomotion = "fly and swim";
            Duck.Age = 2;
            Console.WriteLine("A {0} year old duck can both {1}", Duck.Age, Duck.locomotion);
        }
    }

    public class Animal
    {
        //Properties
        private int age;
        public string locomotion { get; set; }

        //Get / Set Props
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
    }
}
