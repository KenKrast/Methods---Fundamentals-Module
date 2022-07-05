using System;

namespace NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            NxNMatrix(input);
        }

        private static void NxNMatrix(int input)
        {
            for (int rows = 0; rows < input; rows++)
            {
                for (int cols = 0; cols < input; cols++)
                {
                    Console.Write(input + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}