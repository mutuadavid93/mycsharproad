using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProperties
{

    /***************************
     * 
     *   C# PROPERTIES
     * 
     * *************************/

    //Read / Write (get/set), Read Only(get), Write only(set)
    //Auto implement property for fields requiring no logic

    public class Student
    {
        private string _name;
        private int _passmark = 39;

        //Read/Write
        public string Name{
            set {
                if(string.IsNullOrEmpty(value)) {
                    throw new Exception("Name cannot be null nor empty");
                }
                else { this._name = value; }
            }
            get {
                if(string.IsNullOrEmpty(this._name)) {
                    return "No name";
                }
                else { return this._name; }
            }
        }

        //Read only
        public int Passmark{
            get {
                return this._passmark;
            }
        }

        //Autoimplement property
        public string City { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate and Invoke
            Student std = new Student();
            std.Name = "Derek Mkaba";
            
            //Set an autoimplemented prop
            std.City = "Nairobi";

            //print the name and city
            Console.WriteLine("Student name: {0}, Passmark: {1} && City: {2}", std.Name, std.Passmark, std.City);
        }
    }
}
