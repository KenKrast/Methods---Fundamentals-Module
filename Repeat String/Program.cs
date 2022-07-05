using System;

namespace Rectangle_area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());
            string result = RepeatString(input, times);
            Console.WriteLine(result);
        }

        static string RepeatString(string input, int times)
        {
            string result = string.Empty;
            for (int i = 0; i < times; i++)
            {
                result += input;
            }
            return result;
        }
    }
}