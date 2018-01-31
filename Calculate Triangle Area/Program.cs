using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double triangleBase = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());

            double answer = CalculateArea(triangleBase, triangleHeight);

            Console.WriteLine(answer);
        }

        private static double CalculateArea(double triangleBase, double triangleHeight)
        {
            return triangleBase * triangleHeight / 2;
        }
    }
}
