using System;

namespace PerfectNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("İnput value= ");
            int number = Convert.ToInt32(Console.ReadLine());
            PerfectNumber(number);
        }

        static void PerfectNumber(int number)
        {
            int total = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                    total += i;
            }

            if (number == total)
            {
                Console.Write($"{number} is a perfect number");
            }
            else
            {
                Console.Write($"{number} is not a perfect number");
            }

        }
    }
}
