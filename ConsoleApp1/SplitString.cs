using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SplitString
    {
        static void Main(string[] args)
        {
            //1.	WAP to split string into 2 tokens where string is “HELLO$WORLD”

            /*string str = "HELLO$WORLD";
            string[] S = str.Split('$');

            foreach(string s in S)
            {
                Console.WriteLine(s);
            }*/

            string str = "HELLO$Wrold";
            string[] s = str.Split('$');

            string token1 = s[0];
            string token2 = s[1];

            Console.WriteLine("Token1 = " + token1);
            Console.WriteLine("Token2 = " + token2);

            /*Console.WriteLine("Index" + str.IndexOf('0'));
            Console.WriteLine("Index" + str.LastIndexOf("0"));*/
        }
    }
    
}
