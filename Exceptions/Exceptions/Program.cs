using System;
using System.IO;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Global stream object so its 
            //available in the finally block.
            StreamReader stream = null;

            try
            {

                try
                {
                    //Instantiate the StreamReader class.
                    stream = new StreamReader(@"F:\CSharpWorkspace2\Notes\Exceptions.txt");
                    Console.WriteLine(stream.ReadToEnd());
                    stream.Close();
                }
                //Specific Exceptions first
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine("Confirm whether {0} exists", ex.FileName);
                }

                    //General Exceptions Last
                catch (Exception ex)
                {
                    //Log the Errors to a TextFile
                    string filePath = @"F:\CSharpWorkspace\Notes\Log.txt";

                    //Start an inner Exception Handling
                    if (File.Exists(filePath))
                    {

                        StreamWriter straw = new StreamWriter(filePath);

                        straw.Write(ex.GetType().Name);
                        straw.WriteLine();
                        straw.Write(ex.Message);

                        straw.Close();
                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + " not present", ex);
                    }
                }
            }
            catch (Exception evrything)
            {
                //Print inner and Current Exception
                Console.WriteLine("Current Exception: {0}", evrything.GetType().Name);

                //Now check the InnerException Object is not Null
                if (evrything.InnerException != null)
                {
                    Console.WriteLine("Inner Exception: {0}", evrything.InnerException.GetType().Name);
                }
            }

                //Release the system resources.
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
                Console.WriteLine("Resources released");
            }
            
        }
    }
}
