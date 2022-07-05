using System;
using System.Linq;

namespace Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            CheckVowels(input);
        }

        static void CheckVowels(string text)
        {
            Console.WriteLine(text.Count(Vowles => "aouei".Contains(Vowles)));
            
        }
    }
}