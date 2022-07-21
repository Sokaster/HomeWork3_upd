using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Press number A");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Press number B");
            int b = int.Parse(Console.ReadLine());
            int i = 0;
            while (i != -1)
            {
                Console.WriteLine(@"Press operation: + - % / * " + Environment.NewLine + "f(for factorial) s(for sqrt)" + Environment.NewLine + "k(for sqr)" + Environment.NewLine + "e(for exponentation)" + Environment.NewLine + "0 to Exit Programm");
                char y = char.Parse(Console.ReadLine());
                switch (y)
                {
                    case '+':
                        Console.WriteLine($"{a}+{b} = {a + b}");
                        break;

                    case '-':
                        Console.WriteLine($"{a}-{b} = {a - b}");
                        break;

                    case '%':
                        Console.WriteLine($"{a}%{b} = {a % b}");
                        break;

                    case '/':
                        Console.WriteLine($"{a}/{b} = {a / b}");
                        break;

                    case '*':
                        Console.WriteLine($"{a}*{b} = {a * b}");
                        break;

                    case 'f':
                        Console.WriteLine("Press a number for calucate a factorial");
                        int c = int.Parse(Console.ReadLine());
                        int summ = 1;
                        int z = 1;
                        if (c > 0)
                        {
                            for (z = 1; z <= c; z++)
                            {
                                summ *= z;
                            }
                            Console.WriteLine($"Factorial of {c} is {summ}");
                        }
                        if (c < 0)
                        {
                            Console.WriteLine($"For calculate Gamma Function u need update a programm to v 2.00");
                        }
                        if (c == 0)
                        {
                            Console.WriteLine($"Factorial of {c} is 1");
                        }
                        break;

                    case 's':
                        Console.WriteLine("Press a number for calucate a Square root");
                        double d = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Square root of {d} is {Math.Sqrt(d)}");
                        break;

                    case 'k':
                        Console.WriteLine("Press a number for calucate a Square of number");
                        double e = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Square of {e} is {e * e}");
                        break;
                    case 'e':
                        Console.WriteLine($"Press a number that you want to raise a power");
                        double x = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Press the power of a number {x}");
                        double p = double.Parse(Console.ReadLine());
                        Console.WriteLine($"{x} to the {p} power is {Math.Pow(x, p)}");
                        break;
                    case '0':
                        Console.WriteLine($"You Exit a programm");
                        i = -1;
                        break;
                    default:
                        Console.WriteLine("You press a wrong number of operation");
                        break;
                }
            }

        }
    }
}