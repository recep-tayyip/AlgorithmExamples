using System;

namespace BracketMatcher
{
    class Program
    {
        static void Main()
        {
            Console.Write("give a text:");
            string text = Console.ReadLine();
            Console.WriteLine(BracketMatcher(text));
        }

        public static string BracketMatcher(string text)
        {
            int onBracket = 0;
            int offBracket = 0;
            string result = "false";

            foreach (var item in text)
            {
                if (item == '(')
                    onBracket++;
                if (item == ')')
                    offBracket++;
            }
            if (onBracket == offBracket)
                result = "true";

            return result;
        }
    }
}
