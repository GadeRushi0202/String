using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Generic1
    {
        static void Main(string[] args)
        {
           int[]arr = new int[] {1,2,3};
            List<int> list2 = new List<int>();
            list2.Add(10);
            list2.Add(20);

            list2.Insert(2, 30);
            list2.AddRange(arr);

            list2.Remove(10);
            list2.RemoveAt(3);

            foreach(int i in list2)
            {
                Console.WriteLine(i);
            }
        }
        
        
    }
}
