using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Empty
    {
        static void Main(string[] args)
        {
            string str = " ";
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("string  is empty");
            }
            Console.WriteLine(str);
            Console.WriteLine("Enter a Name");
            string name = Console.ReadLine();
            if(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("name is Required");
            }
            else
            {
                Console.WriteLine("Hello"+name);
            }
        }
        
        
    }
}
