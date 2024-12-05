using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class PalindromeString
    {
        static string ReverseString(string str)
        {
            char[] CharArray = str.ToCharArray();
            Array.Reverse(CharArray);
            return new string(CharArray).ToLower();

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string sentence = Console.ReadLine();

            string revstr = ReverseString(sentence);

            if (revstr.ToLower() == sentence.ToLower())
            {
                Console.WriteLine("Palidrome ");
            }
            else
            {
                Console.WriteLine("Not Palidrome");
            }
        }


        ////////////////////////////////////////////////////////////////////////
        ///
       /* static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            string ReverseString = new string(arr);
            if (str.ToLower() == ReverseString.ToLower())
            {
                Console.WriteLine("Palindrome Number");
            }
            else
            {
                Console.WriteLine("Not Palindrome Number");
            }
        }*/


        /////////////////////////////////111111111111111111111111111111111//////////////////////////////////////////////////////////////////////////////


        /*static void Main (string[] args)
        {
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();
            string ReverseString = "";
            for( int i = str.Length - 1; i >= 0; i--)
            {
                ReverseString += str[i];
               
            }
           // Console.WriteLine(ReverseString);
            

            if (str.ToLower() == ReverseString.ToLower())
            {
                Console.WriteLine("Palindrome Number");
            }
            else
            {
                Console.WriteLine("Not Palindrome Number");
            }
        }*/
    }
}
