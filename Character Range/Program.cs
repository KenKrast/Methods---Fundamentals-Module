using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace Character_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            CharRange(firstChar,secondChar);
        }

        static void CharRange(char firstChar, char secondChar)
        {
            ushort startChar = Math.Min(firstChar, secondChar);
            ushort endChar = Math.Max(firstChar, secondChar);
            for (int i = startChar+1; i < endChar; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }

}