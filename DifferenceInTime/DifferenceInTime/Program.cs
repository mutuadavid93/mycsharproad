using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceInTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime baseDate = new DateTime(1970, 1, 1);
            TimeSpan diff = (TimeSpan)DateTime.Now.Subtract(baseDate);
            var milli = Math.Round(diff.TotalSeconds);
            string ref_no = milli.ToString();

            Console.WriteLine("Ref_" + ref_no);

            string dateString = "10/19/2016 9:24:12 AM";
            DateTime DateFromString = 
                DateTime.Parse(dateString, System.Globalization.CultureInfo.InvariantCulture);

            Console.WriteLine("Date From string : {0}", DateFromString.AddDays(3).DayOfWeek);
        }
    }
}
