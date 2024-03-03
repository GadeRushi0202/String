using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Reverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();
            ;// string str = "Hello Wrold";
            string reverseStr = " ";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverseStr += str[i];
            }
            Console.WriteLine(reverseStr);
        }
    }
}
