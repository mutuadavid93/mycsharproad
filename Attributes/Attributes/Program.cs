using System;
using System.Collections.Generic;

namespace Attributes
{
    /*************************
     * 
     *  C# ATTRIBUTES
     *  context: [Obsolete]
     * 
     * **********************/
    class Program
    {
        static void Main(string[] args)
        {
            int result = Program.printSum(new List<int>() { 10, 20, 50, 5 });
            Console.WriteLine(result);

            Console.WriteLine(Program.Add(20, 40));
        }

        [Obsolete("Use printSum(List<int> Numbers) Method instead")]
        public static int Add(int a, int b)
        {
            return(a + b);
        }

        public static int printSum(List<int> Numbers)
        {
            int sum = 0;
            foreach (int number in Numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}
