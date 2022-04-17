using System;

namespace PalindromText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("text:");
            string text = Console.ReadLine();
            string text_pal = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                text_pal += text[i];
            }

            Console.WriteLine($"reverse text:{text_pal}");
            if (text_pal == text)
            {
                Console.WriteLine($"{text} is palindrom");
            }
            else
            {
                Console.WriteLine($"{text} is not palindrom");
            }
        }
    }
}
