using System;
using System.Numerics;

namespace laborat6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для подсчёта его факториала:");
            int y = Convert.ToInt32(Console.ReadLine());
            int x = factorial(y);
            Console.WriteLine($"результат: {x}");
        }
        static BigInteger factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }
       
    }
}
