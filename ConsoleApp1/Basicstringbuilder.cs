using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Basicstringbuilder
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Good Morning ");
            Console.WriteLine(sb);
            Console.WriteLine(sb.GetHashCode());

            sb.Append("Good Night");
            Console.WriteLine(sb);
            Console.WriteLine(sb.GetHashCode());

            /* sb.Remove(2, 6);
             Console.WriteLine(sb);*/

            /* sb.Replace('d', 'D');
             Console.WriteLine(sb);*/

            /*sb.Replace("Morning", "Hello");
            Console.WriteLine(sb);*/

            /*sb.Clear();
            Console.WriteLine(sb);*/


        }
    }
}
