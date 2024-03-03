
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string messege = "Hello to all           ";
            string messeg2 = "hello to all";
            //method string claas
            string str1 = string.Concat(messege.Trim(), "  ", messeg2); //Hello to all  hello to all;
            Console.WriteLine(str1);
            Console.WriteLine(str1.Trim());

            Console.WriteLine(messeg2.ToUpper());
            Console.WriteLine(messeg2.ToLower());

            Console.WriteLine("index- "+messeg2.LastIndexOf('o'));
        }
    }
}
