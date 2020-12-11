using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PmTask_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1.1 ( The program calculates the function y ) ");
            Console.WriteLine(" Student of PM Tech akademy Zinchenko Bohdan ");
            Console.WriteLine("(e^a + 4*lg(c) / Sqrt(b)) * |arctg(d)| + 5/sin(a)");
            Console.Write("input a = ");
            double a = 0;
            var inputa = Double.TryParse(Console.ReadLine(),out a);
            double b = 2001;
            double c = 4;
            double d = 7;
            Console.WriteLine($"(e^{a} + 4*lg({c}) / Sqrt({b})) * |arctg({d})| + 5/sin({a}) ");
            var y = (((Math.Pow(Math.E, a) + 4 * Math.Log10(c))/Math.Sqrt(b)) * Math.Abs(Math.Atan(1 / d))) + 5 / Math.Sin(a);
            Console.WriteLine(y);
            Console.ReadKey();

            
        }
    }
}
