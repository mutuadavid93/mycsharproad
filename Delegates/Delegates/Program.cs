using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    /*************************
     * 
     *      C# DELEGATES
     * 
     * **********************/

    //Declare the delegate
    public delegate void DelagatePointHelloWorld(string strMsg);

    class Program
    {
        static void Main(string[] args)
        {
            //Instatiate the delegate
            DelagatePointHelloWorld del = new DelagatePointHelloWorld(HelloWorld);
            del("Hello world"); //invoke delegate
        }

        //Declare the function
        public static void HelloWorld(string message)
        {
            Console.WriteLine(message);
        }
    }
}
