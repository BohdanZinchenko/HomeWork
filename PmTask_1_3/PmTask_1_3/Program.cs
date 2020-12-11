using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PmTask_1_3
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Task 1.3 Row Calculation ");
            Console.WriteLine("Student of Pm tech Akademy Zinchenko Bohdan ");
            var  sum = 0d;
            var epsilon = 1d / 2001d;
            Console.WriteLine(epsilon);
            var i = 1d;
            sum = 1/(i*(i+1)); 
            while (epsilon < 1 / (i * (i + 1)))
            {
                sum += 1.0 / (i * (i + 1.0));
                i += 1.0;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
           

        }
        
    }
}
