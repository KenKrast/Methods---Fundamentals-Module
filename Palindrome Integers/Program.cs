using System;
using System.Linq;

namespace Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();
           while (input != "END")
           {
               bool palindrome = Palindrome(input);
                Console.WriteLine(palindrome.ToString().ToLower());
                input = Console.ReadLine();
           }
        }

        private static bool Palindrome(string? input)
        {
            int number = int.Parse(input);
            if (number >= 0 && number <= 9)
            {
                return true;
            }

            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] == input[input.Length -1])
                {
                    return true;
                }
            }
            return false;
        }
    }
}