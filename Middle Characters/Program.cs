using System;
using System.Linq;

namespace Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputWord = Console.ReadLine();
            PrintMiddleCharacters(inputWord);
        }

        private static void PrintMiddleCharacters(string? inputWord)
        {
            if (inputWord.Length % 2==0)
            {
                Console.Write(inputWord[inputWord.Length / 2 - 1]);
                Console.WriteLine(inputWord[inputWord.Length / 2]);
            }
            Console.WriteLine(inputWord[inputWord.Length / 2]);
            
        }
    }
}