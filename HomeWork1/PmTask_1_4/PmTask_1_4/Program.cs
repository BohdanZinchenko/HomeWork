using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PmTask_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task_1.4 Find the prime numbers ");
            Console.WriteLine("Student of Pm Tech Akademy Zinchenko Bohdan");

            Console.Write("input pls the lowest number = ");
            var low = 0;
            Int32.TryParse(Console.ReadLine(), out low);
            Console.Write("input pls the top number = ");
            var top = 0;   
            Int32.TryParse(Console.ReadLine(), out top);
            for (var i = low; i <= top; i++)
            {
                var isPrime = true;
                for (var j = 2;j<i;j++)
                {
                    if(i%j==0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (!isPrime) continue;
                Console.WriteLine($" {i} is prime ");
                
            }
            Console.ReadKey();
        }
        
    }
}
