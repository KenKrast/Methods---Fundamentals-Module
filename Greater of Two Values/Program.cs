using System;

namespace Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    int first = int.Parse(Console.ReadLine());
                    int second = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(first, second));
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstChar, secondChar));
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    Console.WriteLine(GetMax(firstString, secondString));
                    break;

            }

           

        }
        static int GetMax(int first, int second)
        {
            if (first > second)
            {
                return first;
            }

            return second;
        }

        static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
            {
                return firstChar;
            }

            return secondChar;
        }

        static string GetMax(string firstString, string secondString)
        {
            int result = firstString.CompareTo(secondString);
            if (result > 0)
            {
                return firstString;
            }

            return secondString;
        }
    }
}