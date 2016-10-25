using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void MyEventHandler(string value);

    class EventPublisher
    {
        private string theVal;

        //Declare the Event
        public event MyEventHandler valueChanged;

        //Declare the .NET EventHandler
        public event EventHandler<ObjChangeEventArgs> ObjChanged;

        public string TheVal
        {
            set
            {
                this.theVal = value;

                //When the value changes, Fire the Event
                this.valueChanged(theVal);

                //Fire (Trigger) the .NET Event
                this.ObjChanged(this, new ObjChangeEventArgs { propToChange = "TheVal" });
            }
        }
    }

    //.NET way of Events
    class ObjChangeEventArgs : EventArgs
    {
        public string propToChange;
    }

    class Program
    {
        static void Main(string[] args)
        {
            EventPublisher obj = new EventPublisher();

            //Use a named function as the Event Handler
            //obj.valueChanged += obj_valueChanged; 

            //Alt: Use an Anonymous delegate as the Event Handler
            obj.valueChanged += delegate(string val)
            {
                Console.WriteLine("The Value changed to {0} ", val);
            };

            //Handle the Event
            obj.ObjChanged += delegate(object sender, ObjChangeEventArgs e)
            {
                Console.WriteLine("{0} had the property {1} changed ", sender.GetType(), e.propToChange);
            };

            string str;
            do
            {
                Console.WriteLine("Enter a Value : \n");
                str = Console.ReadLine().ToLower();

                if (!str.Equals("exit"))
                {
                    obj.TheVal = str;
                }

            } while (!str.Equals("exit"));
            Console.WriteLine("GoodBye Buddy \n");
        }

        //The Real Event Handler
        //Signature matches that of Delegate

        //public static void obj_valueChanged(string value)
        //{
        //    Console.WriteLine("The Value changed to {0} ", value);
        //}

    }
}
