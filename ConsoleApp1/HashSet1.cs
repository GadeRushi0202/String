using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class HashSet1
    {
        static void Main(string[] args)
        {
            /*HashSet<string> str = new HashSet<string>();
            str.Add("Pune");
            str.Add("Beed");
            str.Add("Ashti");
            str.Add("Pune");
            str.Remove("Ashti");
            foreach(string s in str)
            {
                Console.WriteLine(s);
            }*/

            HashSet<string> str1 = new HashSet<string>();
            str1.Add("C");
            str1.Add("C++");
            str1.Add("C#");
            str1.Add("Java");

            HashSet<string> str2 = new HashSet<string>();

            str2.Add("Python");
            str2.Add("Java");
            str2.Add("C#");
            str2.Add("HTMl");

           // str1.UnionWith(str2);//// combine the result & display unique elements
           //str1.IntersectWith(str2);/// first list matched with second & only matched elements will be displayed
           str1.ExceptWith(str2); // compare first list with second & only unique elemetns from list1 get accepted
            foreach (string s in str1)
            {
                Console.WriteLine(s);
            }
        }
    }
}
