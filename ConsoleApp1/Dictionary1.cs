using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Dictionary1
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> dic = new Dictionary<string,string>();
            dic.Add(".Docx", "World File");
            dic.Add(".xlsx", "Exel file");
            dic.Add(".cs", "C# File");

            foreach (KeyValuePair<string, string> item in dic) {
                Console.WriteLine($"{item.Key}{item.Value}");
            }

            Dictionary<int,string> dic1 = new  Dictionary<int,string>();
            dic1.Add(101, "Hr");
            dic1.Add(102, "Sales");
            dic1.Add(103, "Markiting");

            foreach(KeyValuePair<int,string> item in dic1)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }

        }
    }
}
