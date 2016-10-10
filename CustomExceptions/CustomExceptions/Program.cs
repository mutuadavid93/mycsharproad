using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

namespace CustomExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Now use one of those constructors
            //to initialize the error.
            try
            {
                throw new UserNotLoggedInException("Active session already detected, logout first");
            }
            catch (UserNotLoggedInException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    //Create your custom class which Inherates the 
    //Exception class (parent)

    //Make your Custom class Accessible
    //Remotely by using the
    //Serializable Decorator

    [Serializable]
    public class UserNotLoggedInException : Exception
    {
        //Using Constructor Overloading,
        //Create three constrcuctors

        //Overload the Default constructor
        public UserNotLoggedInException()
            : base()
        {

        }

        //Be able to use custom message initialization
        public UserNotLoggedInException(string message)
            : base(message)
        {

        }
        
        //Use the InnerException Object
        public UserNotLoggedInException(string message, Exception innerException)
            : base(message, innerException)
        {

        }

        //A contructor which supports Serialization
        public UserNotLoggedInException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {

        }
    }
}
