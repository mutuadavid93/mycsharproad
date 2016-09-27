using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            //invoke an instance method
            int sum = p.add(3, 7);

            //invoke a static method
            Program.evenNumbers(sum);

            //invoke Pass by Reference
            int i = 0;
            //p.valueparameters(i);
            p.valueparameters(ref i);

            //invoke the output parameter's function
            int total = 0; int product = 0;
            outputparameters(5, 10, out total, out product);

            Console.WriteLine(" Sum = {0} and Product = {1} ", total, product);

            //invoke Parameter Arrays
            int[] numbers = new int[2];
            numbers[0] = 110;
            numbers[1] = 120;
            parameterarrays(numbers);
        }

        public int add(int a, int b)
        {
            return (a + b);
        }

        //Normal method
        public static void evenNumbers(int target) {
            var x = 0;
            for (; x <= target; )
            {
                Console.WriteLine("{0}", x);
                x += 2;
            }
        }

        //passing a parameter by Reference
        public void valueparameters(ref int j)
        {
            j = 101;
        }

        //Output Parameters
        //used when a method is required to return more than one result.
        public static void outputparameters(int x, int y, out int sum, out int product)
        {
            sum = x + y;
            product = x * y;
        }

        //Parameter Arrays
        public static void parameterarrays(params int[] numbers)
        {
            foreach (int k in numbers)
            {
                Console.WriteLine("{0}", k);
            }
        }

    }
}
