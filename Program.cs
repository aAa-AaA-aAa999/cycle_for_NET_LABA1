using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" Введите n");
            Console.ForegroundColor = ConsoleColor.White;
            double n = Convert.ToDouble(Console.ReadLine());
            
            while (n < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" n должен быть положительным");
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" Введите x");

            Console.ForegroundColor = ConsoleColor.White;
            double x = Convert.ToDouble(Console.ReadLine());

            double answer = 0;
            for (int i = 0; i < n + 1; i++)
            {
                int fact = 1;
                if (i != 0)
                {
                    for (int j = 1; j < i * 2 + 1; j++)
                    {
                        fact *= j;
                    }
                }
                answer += (Math.Pow(-1, i) * Math.Pow(x, 2 * i)) / fact;
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($" Ответ: {answer}");
            Console.ReadKey();
        }
    }
}
