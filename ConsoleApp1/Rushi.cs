using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Rushi
    {
        static string ToggleCase(string input)
        {
            var output = new string(input.Select(c => char.IsLower(c) ? char.ToUpper(c) : char.ToLower(c)).ToArray());
            return output;
        }

        static void Main(string[] args)
        {
            string inputStr = "sTrinG";
            string toggleCaseStr = ToggleCase(inputStr);

            Console.WriteLine($"Input: {inputStr}");

            Console.WriteLine($"Output: {toggleCaseStr}");
        }
    }
}
