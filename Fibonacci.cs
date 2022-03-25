using System;

namespace Fibonacci_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("До какого числа считать ряд Фибоначчи?");
            int number = Convert.ToInt32(Console.ReadLine());

            int pervoe = 1;
            Console.Write("{0} ", pervoe);
            int vtoroe = 1;
            Console.Write("{0} ", vtoroe);
            int sum = 0;

            while (number >= sum)
            {
                sum = pervoe + vtoroe;

                Console.Write("{0} ", sum);

                pervoe = vtoroe;
                vtoroe = sum;

            }

            Console.ReadLine();
        }
    }
}


