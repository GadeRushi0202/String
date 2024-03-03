using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FirstOccurence
    {
        static void Main(string[] args)
        {
            string str = "Hello, Wrold";
            char ch = 'o';

            int index = str .IndexOf(ch);

            if (index != -1)
            {
                Console.WriteLine(ch +index);
            }
            else
            {
                Console.WriteLine(ch);
            }
        }
    }
}
