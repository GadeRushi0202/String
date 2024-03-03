using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StringBuilderExample
    {
        static void Main(string[] args)
        {
            string str1 = "Hello to all  ";
            Console.WriteLine(str1);
            Console.WriteLine(str1.GetHashCode());

            str1 = str1 + "Good Morning";
            Console.WriteLine(str1);
            Console.WriteLine(str1.GetHashCode());

            Console.WriteLine("--string Builder Class--");
            StringBuilder str = new StringBuilder("Hello to All ");
            Console.WriteLine(str);
            Console.WriteLine(str.GetHashCode());

            str.Append("Good Night");
            Console.WriteLine(str);
            Console.WriteLine(str.GetHashCode());

            str.Remove(4, 5);
            Console.WriteLine(str);

            str.Replace("Night", "Morning");
            Console.WriteLine(str );


            str.Clear();
            Console.WriteLine(str);

            Console.WriteLine("Capacity="+str.Capacity);
        }
    }
}
