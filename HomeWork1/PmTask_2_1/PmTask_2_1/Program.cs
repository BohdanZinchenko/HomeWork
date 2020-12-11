using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PmTask_2_1
{
    class Program
    {
        static void Main(string[] args)


        {


            Console.WriteLine("Task 2.1 , Game (Rock ,Paper, Scissors)");
            Console.WriteLine("Student of PM Tech Akademy Zinchenko Bohdan");
                Console.WriteLine("You need to input Rock , Paper , Scissors ");
                Console.WriteLine("if you want exit , write exit and if you need help , write help");
                
                var variant = new[] { "Rock", "Paper", "Scissors" };
                var rand = new Random();
                
                var WinStat = 0;
                var LoseStat = 0;
                var DrawStat = 0;
            var play = true;
            while (play)
            {
                Console.Write("input the element what you want to use =  ");
                var player = Console.ReadLine();
                var variantIndex = rand.Next(variant.Length);
                switch (player)
                {
                    case "Rock":
                        Console.WriteLine($"Computer Chose {variant[variantIndex]}");
                        if (variant[variantIndex] == "Paper")
                        { 
                            Console.WriteLine("Player Lose ");
                            LoseStat++;
                        }
                        else if (variant[variantIndex] == "Scissors")
                        {
                            Console.WriteLine("Player Win ");
                            WinStat++;
                        }
                        else if (variant[variantIndex] == "Rock")
                        {
                            Console.WriteLine("DRAW!!!!");
                            DrawStat++;
                        }
                    break;
                    case "Paper":
                        Console.WriteLine($"Computer Chose {variant[variantIndex]}");
                        if (variant[variantIndex] == "Paper")
                        {
                            Console.WriteLine("DRAW!!!");
                            DrawStat++;
                        }
                        else if (variant[variantIndex] == "Scissors")
                        {
                            Console.WriteLine("Player Lose ");
                            LoseStat++;
                        }
                        else if (variant[variantIndex] == "Rock")
                        {
                            Console.WriteLine("Player Win");
                            WinStat++;
                        }
                    break;
                    case "Scissors":
                        Console.WriteLine($"Computer Chose {variant[variantIndex]}");
                        if (variant[variantIndex] == "Paper")
                        {
                            Console.WriteLine("Player Win");
                            WinStat++;
                        }
                        else if (variant[variantIndex] == "Scissors")
                        {
                            Console.WriteLine("DRAW!!!");
                            DrawStat++;
                        }
                        else if (variant[variantIndex] == "Rock")
                        {
                            Console.WriteLine("Player Lose");
                            LoseStat++;
                        }
                    break;
                    case "help":
                        Console.WriteLine("You can input Paper , Scissors or Rock");
                        Console.WriteLine("If you want to exit just right exit");
                   break;
                    case "exit":
                        play = false;
                    break;
                    default:
                    Console.WriteLine("Incorect input , pls chose something from this : Rock, Paper, Scissors , help, exit");
                        break;



                }
                
                
            }

            Console.WriteLine("Stats:");
            Console.WriteLine($"Wins = {WinStat}");
            Console.WriteLine($"Draws = {DrawStat}");
            Console.WriteLine($"Loses = {LoseStat}");
            Console.ReadKey();

        }
    }
}
