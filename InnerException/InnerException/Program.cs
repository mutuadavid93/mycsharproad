using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InnerException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter First Number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter First Number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int sum = num1 / num2;

                Console.WriteLine("Sum = {0} ", sum);
            }
            catch (Exception ex)
            {
                string filePath = @"F:\CSharpWorkspace\Notes\Log.txt";
                StreamWriter straw = new StreamWriter(filePath);

                straw.Write(ex.GetType().Name);
                straw.WriteLine();
                straw.Write(ex.Message);

                straw.Close();
            }
            
        }
    }
}
