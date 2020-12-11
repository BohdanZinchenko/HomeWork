using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PmTask_2_4
{
    class Program
    {
        private static Stopwatch time = new Stopwatch();
        private static int fails=0;
        private static int pointN;
        static void Main(string[] args)
        {
            
            time.Start();
            int Min=0;
            int Max=0;
            while (Min == 0 && Max == 0)
            {
                Console.Write("input Min value = ");
                var inputMin = Console.ReadLine();
                Console.Write("input Max value = ");
                var inputMax = Console.ReadLine();
                if (!int.TryParse(inputMin, out Min) && !int.TryParse(inputMax, out Max))
                {
                    Console.WriteLine("incorect number");
                    continue;
                }
                int.TryParse(inputMin, out Min);
                int.TryParse(inputMax, out Max);
                if (Max <= Min || Min < 0 || Max > 1000000)
                {
                    Console.WriteLine("incorect number");
                    Min = 0;
                    Max = 0;
                   
                }


            }
         
          
            for (int i = 1;i<100;i++)
            {
                if (Math.Pow(2, i) > Max + 1)
                {
                    if (Math.Pow(2, i) - Max + 1 <= Math.Pow(2, i + 1) - Max + 1)
                    {
                        pointN = i;
                        break;
                    }
                    else
                    {
                        pointN = i+1;
                        break;
                    }
                }
            }
            var random = new Random();
            var number = random.Next(Min, Max + 1);
            
            FindNum(number);
            
        }


        public static void FindNum(int number)
        {

            int answer = 0;
            do
            {
                Console.Write("What number you think = ");
              var input = Console.ReadLine();
                if (input == "Exit")
                {
                    Environment.Exit(0);
                }
                if (!int.TryParse(input, out answer))
                {
                    continue;
                }

                int.TryParse(input, out answer);

                if (answer < number)
                {
                    Console.WriteLine("Too low");
                    fails++;
                }
                if (answer > number)
                {
                    Console.WriteLine("Too much!");
                    fails++;
                }
            } while (answer != number);
            Console.WriteLine("Good Job , you are right");
            if (100 * (pointN - fails)/pointN <= 0)
            {
                Console.WriteLine($"Points = {0}");
            }
            else
            {
                Console.WriteLine($"Points = {100 * (pointN - fails) / pointN}");
            }
            Console.WriteLine($"You fail = {fails} times");
            time.Stop();
            Console.WriteLine($"You spend {time.Elapsed}  to find the num what you need ");

            Console.ReadKey();
        }

    }
}
