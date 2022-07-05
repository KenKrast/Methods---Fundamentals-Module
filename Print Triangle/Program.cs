using System;

namespace Print_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i < input; i++)
            {
                PrintTriangle(1, i);
            }

            for (int i = input; i >= 1; i--)
            {
                PrintTriangle(1, i);
            }
        }

        private static void PrintTriangle(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine(); 
        }
    }
}