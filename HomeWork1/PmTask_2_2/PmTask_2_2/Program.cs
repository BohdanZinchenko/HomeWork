using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PmTask_2_2
{
    class Program
    {
        public  static double Calculation(string[] figure)
        {          
            var S = 0d;
                switch (figure[0])
                {
                    case "Circle":
                        if (figure[2] != null)
                        {
                            Console.WriteLine("Incorect input for Circle");
                        }
                        else
                        {
                            var r = 0d;
                            Double.TryParse(figure[1], out r);
                            return S = Math.Pow(r, 2) * Math.PI;

                        }
                        break;
                    case "Square":
                        if (figure[2] != null)
                        {
                            Console.WriteLine("Incorect input for Square");
                        }
                        else
                        {
                            var side = 0d;
                            Double.TryParse(figure[1], out side);
                            return S = Math.Pow(side, 2);
                        }
                        break;
                    case "Triangle":
                        if (figure[2] == null)
                        {
                            Console.WriteLine("Incorect input for Triangle");
                        }
                        else
                        {
                            var a = 0d; var b = 0d; var c = 0d; var p = 0d;
                            Double.TryParse(figure[1], out a);
                            Double.TryParse(figure[2], out b);
                            Double.TryParse(figure[3], out c);
                            p = (a + b + c / 2);
                            return S = (Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
                        }
                        break;
                    case "Rectangle":
                        if (figure[3] != null)
                        {
                            Console.WriteLine("Incorect input for Rectangle");
                        }
                        else
                        {
                            var a = 0d; var b = 0d;
                            Double.TryParse(figure[1], out a);
                            Double.TryParse(figure[2], out b);
                            return S = (a * b);
                        }
                        break;
                    case "exit":
                        return -2;
                    default:
                        Console.WriteLine("Incorect input !!! ");
                        Console.WriteLine("Try to use defoult figures like Rectangle, Circle, Square, Triangle");
                        Console.WriteLine("And pls write the right parameters for this figures: Like if you chose Circle , next must be only R");
                    break;
                        

                }


            return -1;
            
        }
        static void Main(string[] args)
        {
            
            bool work = true;
            var S = 0d;
            if (args.Length > 0)
            {
                while (work)
                {
                    S = Calculation(args);
                   
                    if (S == -1)
                    {
                        work = false;
                    }
                    else
                    {
                        Console.WriteLine($"The Area = {S}");
                    }
                }

            }
            else
            {
                Console.WriteLine("This is Program for S ");
                Console.WriteLine("You can chose one of this figures: Rectangle, Circle, Square, Triangle, write exit for exit");

                int i = 0;
                
                while (work)
                {
                    string[] figure = new string[4];
                    try
                    {
                        foreach (string s in Console.ReadLine().Split(' '))
                        {
                            figure[i] = s;
                            i++;
                        }

                    }
                    catch{
                        Console.WriteLine( new ArgumentOutOfRangeException(nameof(figure)));
                    }
                    S = Calculation(figure);
                    
                    if (S == -2)
                    {
                        work = false;

                    }
                    else if (S == -1)
                    {
                        i = 0;
                    }
                    else
                    {
                        Console.WriteLine($"The Area = {S}");
                        i = 0;
                    }
                }
            }

          
        }

    }
}
