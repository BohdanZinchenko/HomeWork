using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PmTask_3
{
    class Program
    {
       private static bool work = true;

        private static double calculation(string expression)
        {
            var num1 = 0;
            var num2 = 0;
            if(int.TryParse(expression,out num1))
            {
                Console.WriteLine(checked(num1));
                return 1;
            }
            if (expression == "help")
            {
                Console.WriteLine("You can use this for calculate different expression");
                Console.WriteLine("Use + , - , / , % , * , pow ");
                Console.WriteLine("Or you can use & , | , ^ ");
                Console.WriteLine("And Unary bit operations like <<, >> or  for Factorial use a!");
                return 1;
            }
            if (expression == "exit")
            {
                Environment.Exit(0);
            }
            char[] arg = expression.ToCharArray();

            for (int i = 0;i<arg.Length;i++)
                {
                if (arg[i] == '+')
                {
                    string[] elem = expression.Split('+');
                    if (int.TryParse(elem[0], out num1) && int.TryParse(elem[1], out num2))
                    {
                        try
                        {
                            Console.WriteLine(checked(num1 + num2));
                        }
                        catch( System.OverflowException e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                        return 0;
                    }
                    
                    
                }
                
                else if (arg[i] == '-' && i!=0)
                {
                    if (arg[0] == '-')
                    {
                        string[] elem = expression.Split('-');
                        if (int.TryParse(elem[1], out num1))
                        {

                            num1 = num1 * -1;
                            if (elem.Length == 4)
                            {
                                if (int.TryParse(elem[3], out num2))
                                {
                                    num2 = num2 * -1;
                                    try
                                    {
                                        Console.WriteLine(checked(num1 - num2));
                                    }
                                    catch (System.OverflowException e)
                                    {
                                        Console.WriteLine(e.ToString());
                                    }
                                    return 0;
                                    
                                }

                            }
                            else
                            {
                                if(int.TryParse(elem[2], out num2))
                                {
                                    try
                                    {
                                        Console.WriteLine(checked(num1 - num2));
                                    }

                                    catch (System.OverflowException e)
                                    {
                                        Console.WriteLine(e.ToString());
                                    }
                                    return 0;
                                }
                            }
                            return -1;
                            
                            
                        }
                        
                        
                    }
                    else
                    {
                        string[] elem = expression.Split('-');
                        if (int.TryParse(elem[0], out num1) )
                        {

                            if (elem.Length == 3)
                            {
                                if (int.TryParse(elem[2], out num2))
                                {
                                    num2 = num2 * -1;
                                    try
                                    {
                                        Console.WriteLine(checked(num1 - num2));
                                    }

                                    catch (System.OverflowException e)
                                    {
                                        Console.WriteLine(e.ToString());
                                    }
                                    return 0;
                                }

                            }
                            else
                            {
                                if (int.TryParse(elem[1], out num2))
                                {
                                    try
                                    {
                                        Console.WriteLine(checked(num1 - num2));
                                    }

                                    catch (System.OverflowException e)
                                    {
                                        Console.WriteLine(e.ToString());
                                    }
                                    return 0;
                                }
                            }
                            return -1;
                            
                        }
                    }
                }
                else if (arg[i] == '*')
                {
                    string[] elem = expression.Split('*');
                    if (int.TryParse(elem[0], out num1) && int.TryParse(elem[1], out num2))
                    {

                        try
                        {
                            Console.WriteLine(checked(num1 * num2));
                        }

                        catch (System.OverflowException e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                        return 0;
                    }
                }
                
                else if (arg[i] == '/')
                {
                    try
                    {
                        string[] elem = expression.Split('/');
                        if (int.TryParse(elem[0], out num1) && int.TryParse(elem[1], out num2))
                        {

                            try
                            {
                                Console.WriteLine(checked(num1 / num2));
                            }

                            catch (System.OverflowException e)
                            {
                                Console.WriteLine(e.ToString());
                            }
                            return 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return -1;
                    }
                }
                else if (arg[i] == '%')
                {
                    try
                    {
                        string[] elem = expression.Split('%');
                        if (int.TryParse(elem[0], out num1) && int.TryParse(elem[1], out num2))
                        {
                            try
                            {
                                Console.WriteLine(checked(num1 % num2));
                            }

                            catch (System.OverflowException e)
                            {
                                Console.WriteLine(e.ToString());
                            }
                            return 0;
                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return -1;
                    }
                }
                else if (arg[i] == 'p' && arg[i + 1] == 'o' && arg[i + 2] == 'w')
                {
                    string[] elem = expression.Split('p', 'o', 'w');
                    if (int.TryParse(elem[0], out num1) && int.TryParse(elem[3], out num2))
                    {

                        try
                        {
                            Console.WriteLine(checked(Math.Pow(num1,num2)));
                        }

                        catch (System.OverflowException e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                        return 0;
                    }
                }
                else if(arg[i]=='&' && arg[0]!=0)
                {
                    if (arg[i+1] == '-')
                    {
                        Console.WriteLine("Invalid input ,number dont must be negative");
                        return -1;
                    }
                    string[] elem = expression.Split('&');
                    if (int.TryParse(elem[0], out num1) && int.TryParse(elem[1], out num2))
                    {

                        try
                        {
                            Console.WriteLine(checked(num1 & num2));
                        }

                        catch (System.OverflowException e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                        return 0;
                    }
                }
                else if (arg[i] == '|' && arg[0] != 0)
                {
                    
                    if (arg[i+1] == '-')
                    {
                        Console.WriteLine("Invalid input ,number dont must be negative");
                        continue;
                    }
                    string[] elem = expression.Split('|');
                    if (int.TryParse(elem[0], out num1) && int.TryParse(elem[1], out num2))
                    {

                        try
                        {
                            Console.WriteLine(checked(num1 | num2));
                        }

                        catch (System.OverflowException e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                        return 0;
                    }
                }
                else if (arg[i] == '^' && arg[0] != 0)
                {
                    if (arg[i+1] == '-')
                    {
                        Console.WriteLine("Invalid input ,number dont must be negative");
                        continue;
                    }
                    string[] elem = expression.Split('^');
                    if (int.TryParse(elem[0], out num1) && int.TryParse(elem[1], out num2))
                    {
                        try
                        {
                            Console.WriteLine(checked(num1 ^ num2));
                        }

                        catch (System.OverflowException e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                        return 0;
                    }
                }
                else if(arg[0]=='>'&& arg[1]=='>')
                {
                    if (arg[2] == '-')
                    {
                        Console.WriteLine("Invalid input ,number dont must be negative");
                        return -1;
                    }
                    else
                    {
                        
                        string[] elem = expression.Split('>');
                        if (int.TryParse(elem[2], out num1))
                        {

                            Console.WriteLine(checked(num1 >> 1));
                            return 0;
                        }
                    }
                }
                else if (arg[0] == '<' && arg[1] == '<')
                {
                    if (arg[2] == '-')
                    {
                        Console.WriteLine("Invalid input ,number dont must be negative");
                        return -1;
                    }
                    else
                    {

                        string[] elem = expression.Split('<');
                        if (int.TryParse(elem[2], out num1))
                        {

                            Console.WriteLine(checked(num1 << 1));
                            return 0;
                        }
                    }
                }
                else if(arg[0] !='!'&& arg[i]=='!')
                {
                    var factorial = 1;
                    string[] elem = expression.Split('!');
                    if (int.TryParse(elem[0], out num1))
                    {
                        try
                        {
                            for (int k = 1; k <= num1; k++)
                            {
                                factorial = checked(factorial * k);
                            }
                            Console.WriteLine(checked(factorial));
                        }
                        catch (System.OverflowException ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                        return 0;
                    }
                }
                


            }
            Console.WriteLine("you write something wrong , Try angain , use help if you need it");
            return -1;
            
           
        }
        static int Main(string[] args)
        {
            if(args.Length>0)
            {
                try
                {
                    for (int i = 0; i < args.Length - 1; i++)
                    {
                        calculation(args[i]);
                    }
                }
                catch (System.IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.ToString());
                    return -1;
                }
                
                
                Environment.Exit(0);
                
               
            }
            else
            {
                Console.WriteLine("Task 3 , Calculator");
                Console.WriteLine("Student of Pm Tech Akademy Zinchenko Bohdan");
                Console.WriteLine("You can use this for calculate different expression");
                Console.WriteLine("Use + , - , / , % , * , pow ");
                Console.WriteLine("Or you can use & , | , ^ ");
                Console.WriteLine("And Unary bit operations like <<, >> or  for Factorial use a!");

                while (work)
                {
                    string expression = Console.ReadLine();
                    
                    calculation(expression);
                }
               
                
                
            }
            return -1;
        }
    }
}
