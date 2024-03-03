using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Alpa
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            int alphabetCount = 0;
            int digitCount = 0;
            int specialCharCount = 0;

            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    alphabetCount++;
                }
                else if (char.IsDigit(c))
                {
                    digitCount++;
                }
                else
                {
                    specialCharCount++;
                }
            }

            Console.WriteLine("Total Alphabets: " + alphabetCount);
            Console.WriteLine("Total Digits: " + digitCount);
            Console.WriteLine("Total Special Characters: " + specialCharCount);
        }
    }
}
