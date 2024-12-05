using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Imp
    {
        static void Main(string[] args)
        {

            /* for(int i = 100; i <= 500; i+=100)
             {
                 Console.WriteLine(i);
             }*/

            /* for(int i =1; i<=5; i++)
             {
                 Console.WriteLine(i*100);
             }*/


            /*            Console.WriteLine("Enter a number");
                        int num = Convert.ToInt32(Console.ReadLine());
                        int a = 1;
                        for (int i = 2; i <= num / 2; i++)
                        {
                            if (num % i == 0)
                            {
                                a = 0;
                                break;
                            }
                        }
                        if (a == 1)
                        {
                            Console.WriteLine("prime num");
                        }
                        else
                        {
                            Console.WriteLine("Not prime num");
                        }*/

            /*int rows = 6;
            for (int i = rows; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/
            for (int i = 1; i <= 100; i++)
            {
                int a = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        a = 1;
                        break;
                    }
                }
                if (a == 0)
                {
                    Console.WriteLine(i);
                }
            }
          

        }
    }
}
