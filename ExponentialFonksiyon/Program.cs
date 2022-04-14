using System;

namespace ExponentialFonksiyon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a base value= ");
            int baseNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Give a exponent value= ");
            int expoNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write($"{baseNumber} ^ {expoNumber} = {Exponant(baseNumber,expoNumber)}");
        }

        static int Exponant(int number, int expo)
        {
            if (expo==0)
            {
                return 1;
            }
            else
            {
                return number * Exponant(number, expo - 1);
            }
        }
    }
}
