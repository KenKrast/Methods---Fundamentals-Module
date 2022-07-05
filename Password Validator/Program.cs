using System;
using System.Diagnostics.SymbolStore;
using System.Linq;

namespace Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            bool correctPassLenght = CheckPassLenght(pass);
            bool correctPassSymbols = CheckPassSymbols(pass);
            bool correctPassDigits = CheckPassAmountDigits(pass);
            if (!correctPassLenght)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!correctPassSymbols)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!correctPassDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (correctPassLenght && correctPassSymbols && correctPassDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool CheckPassAmountDigits(string pass)
        {
            int count = 0;
            foreach (var symbol in pass)
            {
                if (char.IsDigit(symbol))
                {
                    count++;
                }
            }
            return count >= 2;
        }

        private static bool CheckPassSymbols(string pass)
        {
            return pass.All(symbols => char.IsLetterOrDigit(symbols));
        }

        private static bool CheckPassLenght(string pass)
        {
            return pass.Length >= 6 && pass.Length <= 10;
        }
    }
}