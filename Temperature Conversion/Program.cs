using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Conversion
{
    class Program
    {
         static decimal FahrenheitToCelsius(decimal degrees)
        {
            decimal celsius = (degrees - 32) * 5 / 9;
            return celsius;
        }

        static void Main()
        {
            
            decimal t = decimal.Parse(Console.ReadLine());
            t = FahrenheitToCelsius(t);

            Console.Write("{0:F2}", t);

        }
    }
}
