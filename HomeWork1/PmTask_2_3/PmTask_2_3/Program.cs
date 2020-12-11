using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PmTask_2_3
{
    class Program
    {
        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        static int[] ShakerSort(int[] array)
        {
            for (var i = 0; i < array.Length / 2; i++)
            {
                var swapFlag = false;
                for (var j = i; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        swapFlag = true;
                    }
                }
                for (var j = array.Length - 2 - i; j > i; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        Swap(ref array[j - 1], ref array[j]);
                        swapFlag = true;
                    }
                }
                if (!swapFlag)
                {
                    break;
                }
            }

            return array;
        }
        static void Stat(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                {
                Console.Write($"{array[i]}, ");
            }
            var sum = 0;
            var standardDeviation = 0d;

            Console.WriteLine() ;
            Console.WriteLine($"Min = {array[0]}");
            Console.WriteLine($"Max = {array[array.Length - 1]}");
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];

            }
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {sum / array.Length}");
            for (int i = 0; i < array.Length; i++)
            {
                standardDeviation = Math.Pow((array[i] - sum), 2);
            }
            standardDeviation = Math.Sqrt(standardDeviation / array.Length);
            Console.WriteLine($"Standard Deviation = {standardDeviation}");
        }
        static int Main(string[] args)
        {

            if (args.Length > 0)
            {
                var arr = new int[args.Length];
                for (int i = 0; i < args.Length; i++)
                {
                    if (Int32.TryParse(args[i], out arr[i]))
                    {
                        Int32.TryParse(args[i], out arr[i]);
                    }
                    else
                    {
                        return -1;
                    }
                }
                ShakerSort(arr);
                Stat(arr);
                

            }
            else
            {
                Console.WriteLine(" Task 2.3 Array statistic and array sort");
                Console.WriteLine(" Student of Pm Tech Akademy Zinchenko Bohdan");
                Console.Write("input Lenght of your array = ");
                
                var n = 0;
                Int32.TryParse(Console.ReadLine(), out n);

                var array = new int[n];

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"input elem {i} = ");
                    var elem = Console.ReadLine();
                    if (Int32.TryParse(elem, out array[i]))
                    {
                        Int32.TryParse(elem, out array[i]);
                    }
                    else
                    {
                        Console.WriteLine("Error Input");
                        i--;
                        continue;
                    }
                }
                ShakerSort(array);
                Stat(array);
                Console.ReadKey();
            }
            return 0;

            
        }
    }
}
