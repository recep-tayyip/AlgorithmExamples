using System;

namespace OverValueDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input array length value=");
            int lenght = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[100];

            for (int i = 0; i < lenght; i++)
            {
                Console.Write("Enter array value=");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < lenght; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();

            for (int i = 0; i < lenght; i++)
            {
                for (int j = i + 1; j < lenght; j++)
                {
                    if (array[i] == array[j])
                    {
                        for (int k = j; k < lenght; k++)
                        {
                            array[k] = array[k + 1];
                        }
                        lenght--;
                        j--;
                    }
                }
                Console.Write($"{array[i]} ");
            }
        }
    }
}
