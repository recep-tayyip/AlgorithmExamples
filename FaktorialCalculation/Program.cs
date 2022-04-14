using System;

namespace FaktorialCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number=");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write($"{number}! = {Faktorial(number)}");
        }

        static int Faktorial(int number)
        {
            if (number==0)
            {
                return 1;
            }
            else
            {
                return number * Faktorial(number - 1);
            }
        }
    }
}
