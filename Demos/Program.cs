using System;
using System.Security.Cryptography;

namespace Sign_Of_Three_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Increment(10);
        }

        private static int Increment(int a)
        {
            a += 10;
            Console.WriteLine(a);
            return a;
        }
    }

}