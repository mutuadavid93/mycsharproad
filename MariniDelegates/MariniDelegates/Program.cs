using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariniDelegates
{
    public delegate string MyDelegate(int a, int b);
    class Program
    {
        public static string funct(int x, int y)
        {
            return (x * y).ToString();
        }

        public static string myFunc(int a, int b)
        {
            return (a + b).ToString();
        }

        static void Main(string[] args)
        {
            MyDelegate f = funct;
            string result = f(10, 20);
            Console.WriteLine("This Result is : {0}", result);

            //Anonymous Delegate
            MyDelegate f2 = delegate(int z, int g)
            {
                return (g + z).ToString();
            };
            Console.WriteLine("This Result is : " + f2(10, 20));
        }
    }
}
