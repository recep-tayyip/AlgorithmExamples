using System;

namespace VowelsOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input text:");
            string text = Console.ReadLine();


            Console.WriteLine($"number of vowel:{StringChallenge(text)}");

        }

        public static string StringChallenge(string text)
        {
            int counter = 0;
            string vowels = "a,e,ı,i,o,ö,u,ü";
            foreach (var letter in text)
            {
                foreach (var vowel in vowels)
                {
                    if (letter == vowel)
                        counter++;
                }
            }
            return Convert.ToString(counter);
        }
    }
}
