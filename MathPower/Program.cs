using System;

namespace Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Pow(num1, num2));
        }
        
    }
}