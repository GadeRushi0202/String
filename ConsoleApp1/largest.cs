using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class largest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence");
            string sentence = Console.ReadLine();

            string LongestWord = " ";
            int maxLength = 0;

            string[] words = sentence.Split(' ');

            for (int i =0; i < words.Length; i++)
            {
                if (words[i].Length > maxLength)
                {
                    maxLength = words[i].Length;
                    LongestWord = words[i];

                }
            }
            Console.WriteLine("The longest word is :-   "+LongestWord);
        }
    }
}

