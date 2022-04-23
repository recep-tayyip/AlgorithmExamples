using System;

namespace SearchingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a number=");
            int number = Convert.ToInt32(Console.ReadLine());
            int output = 0;

            for (int i = 1; i < number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    output += i;
            }
            Console.WriteLine(output);
        }
    }
}
