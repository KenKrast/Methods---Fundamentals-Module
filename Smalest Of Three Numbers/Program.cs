﻿using System;

namespace Smallest_Of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(SmallestNumber(num1, num2, num3));
        }
        static int SmallestNumber(int a, int b, int c) => Math.Min(a, Math.Min(b, c));
    }
}