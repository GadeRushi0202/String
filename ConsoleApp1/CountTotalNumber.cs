using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //5.	Write a C# program to count total number of words in a string. 
    internal class CountTotalNumber
    {
        static void Main(string[] args)
        {
            string str = "This is a string ";
            int wordcount = 0;
            string[] words = str.Split(' ');

            for (int i =0; i < words.Length; i++)
            {
                wordcount++;
            }
            Console.WriteLine(wordcount);


        }
    }
}
