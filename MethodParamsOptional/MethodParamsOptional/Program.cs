using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MethodParamsOptional
{
    class Program
    {
        /****************************
         * 
         *  MAKE METHOD PARAMETERS
         *      OPTIONAL
         * 
         * *************************/
        static void Main(string[] args)
        {
            // 1. Using parameter arrays.
            //Now invoke addNumbers

            //addNumbers(10, 20, new object[] {25, 30});
            addNumbers(10, 20, 40, 70);

            // 2. Using default parameters e.g numb2 = 40
            //Using Named parameters
            findSum(70, secondNo: 50);

            // 3. OptionalAttribute
            results(50, 50);
        }

        //Create a Method with parameter arrays
        public static void addNumbers(int numb1, int numb2, params object[] restOfNumbs)
        {
            int result = (numb1 + numb2);
            if (restOfNumbs != null)
            {
                foreach (int i in restOfNumbs)
                {
                    result += i;
                }
            }
            Console.WriteLine("Sum is = {0}", result);
        }

        //Method Demonstrating Default parameters
        public static void findSum(int firstNo, int secondNo = 30)
        {
            Console.WriteLine("Total = {0}", (firstNo + secondNo));
        }

        
        //Demonstrating OtpionalAttribute
        public static void results(int a, int b, [OptionalAttribute] int[] extraNos)
        {
            Console.WriteLine("Results = {0}", (a+b));
        }
    }
}
