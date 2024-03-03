using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class VowelAndConsonants
    {
        static void Main(string[] args)
        {
            string str = "Hello Wrold";
            int vowels = 0;
            int consonants= 0;
            for(int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if(ch =='a'||ch=='e'||ch=='i'|| ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }
            }
            Console.WriteLine(vowels);
            Console.WriteLine(consonants);
        }
    }
}
