using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PmTask_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Bookmaker's margin count ");
            Console.WriteLine(" Student of Pm Tech Academy Zinchenko Bohdan");
            Console.Write(" Name Team 1 = ");
            var Team1 = Console.ReadLine();
            Console.Write(" Name Team 2 = ");
            var Team2 = Console.ReadLine();
            double win1, drow, win2;
            Console.Write($" Coef for win {Team1} = ");
            var coef1 = Double.TryParse(Console.ReadLine(),out win1);
            Console.Write(" Coef for drow = ");
            var coef2 = Double.TryParse(Console.ReadLine(),out drow);
            Console.Write($" Coef for win  {Team2} = ");
            var coef3 = Double.TryParse(Console.ReadLine(),out win2);
            var M = ((1 / win1) + (1 / drow) + (1 / win2) - 1) * 100;
            var Pwin1 = 1 /win1 * 100 - (M*1/win1) ;
            Console.WriteLine($" Win {Team1} : {Math.Round(Pwin1, 0)}%");
            var Pwin2 = 1 /win2 * 100-(M * 1 / win1);
            Console.WriteLine($" Win {Team2} : {Math.Round(Pwin2, 0)}%");
            var Pdrow = 1 /drow * 100-(M * 1 / win1);
            Console.WriteLine($" Drow  : {Math.Round(Pdrow,0)}%");  
            Console.WriteLine($" bookmaker's margin : {Math.Round(M,0)}%");
            Console.ReadKey();

        }
    }
}
