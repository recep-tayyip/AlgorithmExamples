using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number= ");
            int number = Convert.ToInt32(Console.ReadLine());
            PrimeNumber(number);
        }

        static void PrimeNumber(int number)
        {
            bool isPrime = true;
            if (number==0 || number==1)
            {
                Console.Write("Prime numbers start from 2");
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number%i==0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write($"{number} is a prime number");
                }
                else
                {
                    Console.Write($"{number} is not a prime number");
                }
            }
        }
    }
}
