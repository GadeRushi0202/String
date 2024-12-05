using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Basic
    {
        static void Main(string[] args)
        {
            /*string str1 = "Rushikesh Gade";
            string str2 = "Hello Wrold";
            Console.WriteLine("My Nmae:- "+str1); //My Nmae:- Rushikesh Gade
            Console.WriteLine(str1[0]);//R
            Console.WriteLine(str1[1]);//u
            Console.WriteLine(str1.Length);//14
            Console.WriteLine(str1.IndexOf('R'));//0
            Console.WriteLine(str1.IndexOf('G'));//10
            Console.WriteLine(str1.IndexOf('s'));//2
            Console.WriteLine(str1.LastIndexOf('s'));//7
            Console.WriteLine(str1.ToUpper()) ;//RUSHIKESH GADE
            Console.WriteLine(str1.ToLower());//rushikesh gadet
            Console.WriteLine(str1.StartsWith("Rushikesh"));//true
            Console.WriteLine(str1.StartsWith("Rushi"));//true
            Console.WriteLine(str1.StartsWith("R"));//True
            Console.WriteLine(str1.StartsWith("u"));//False
            Console.WriteLine(str1.EndsWith("Gade"));//True
            string res = str2 + " " + "Good Morning";
            Console.WriteLine(res);*/

            // Basic of String


            /*string messege = "Hello to All";
            Console.WriteLine(messege);
            Console.WriteLine(messege.GetHashCode());
            messege = messege + "Good Morning";
            Console.WriteLine(messege);
            Console.WriteLine(messege.GetHashCode());
            messege = messege + "Good day";
            Console.WriteLine(messege);
            Console.WriteLine(messege.GetHashCode());*/

            //Method of String
            //Concat();

            /*string FirstName = "Rushi";
            string LastName = "Gade";
            string str = string.Concat(FirstName," " ,LastName);
            Console.WriteLine(str);*/


            //method of Trim() TrimEnd() TrimStart()

            /*string messege = "  Hello to All   ";
            string messege2 = "Good Morning";
            string str = string.Concat(messege.TrimEnd(),messege2);
            Console.WriteLine(str);
            Console.WriteLine(str.Trim());*/

            //ToUpper() ToLower()

            /*  string msg = "Good Morning";
              Console.WriteLine(msg.ToUpper()); // GOOD MORNING
              Console.WriteLine(msg.ToLower()); //good morning*/

            //IndexOf() IndexLast()

            /* string msg = "Good Morning";
             Console.WriteLine(msg.IndexOf('G'));//0
             Console.WriteLine(msg.IndexOf('d'));//3
             string msg1 = "Good Night";
             Console.WriteLine(msg1.LastIndexOf('h'));*/

            //Seperate by character

            /*string Name = "Gade Rushikesh";
            for(int i = 0; i < Name.Length; i++)
            {
                Console.WriteLine(Name[i]);
            }*/

            // Split ()

            /*string Name = "Gade Rushikesh";
            string[] arrstring = Name.Split(' ');
           Console.WriteLine(Name);             //Gade  Rushikesh
            Console.WriteLine(arrstring[0]);    //Gade
            Console.WriteLine(arrstring[1]);    //Rushikesh
            Console.WriteLine("ForEach 1");

            foreach (string s in arrstring)
            {
                Console.WriteLine(s); // Gade
                                      //Rushikesh
            }
            Console.WriteLine("Index Based");


            string N1 = "Rushikesh,Rajesh,Vishal,Pratiksha,Rutuja,shubham";
            //Converting string to array
            string[] stringarr = N1.Split(',');
            Console.WriteLine(stringarr[0]);
            Console.WriteLine(stringarr[2]);
            Console.WriteLine(stringarr[5]);

            Console.WriteLine("ForEach 1");

            foreach (string f in stringarr)
            {
                Console.WriteLine(f);
            }*/


            //Convertig string to Char array

            /* string Name = "Gade Rushikesh";
             char[] ch = Name.ToCharArray();
             foreach (char c in ch)
             {
                 Console.WriteLine(c);
             }

             //Convert char array to string
             string str2 = new string (ch);
             Console.WriteLine (str2);*/

            //ISNullorEmpty

            /* string str = null;
             Console.WriteLine(str);
             if (str == null || str ==" ")
             {
                 Console.WriteLine("String  is Empty");
             }
             Console.WriteLine(str);*/

            /*string str = "This is a String";
            int countWords = 0;
            string[] words = str.Split(' ');

            for(int i = 0; i< words.Length; i++)
            {
                countWords++;
            }
            Console.WriteLine(countWords);*/

            /* Console.WriteLine("Enter a Sentance");
             string str = Console.ReadLine();
             string[] words = str.Split(' ');
             string LongetWords = " ";
             int MaxLength = 0;

             for(int i =0; i< words.Length; i++)
             {
                 if (words[i].Length > MaxLength)
                 {
                     MaxLength = words[i].Length;
                     LongetWords = words[i];
                 }
             }
             Console.WriteLine("Longest Word = " + LongetWords);*/

            /*string str = "Hello to all";
            char targetChar = 'l';
            int count = 0;
            foreach(Char c in str)
            {
                if(c == targetChar)
                {
                    count++;
                }
            }
            Console.WriteLine("The charcter "+targetChar +" " + "apperas "+ " "+count +" "+"Times" );*/
            string message = "  Hello World";
            string str1 = message.TrimStart();
            Console.WriteLine(str1);

            string message1 = "Hello World    ";
            string message2 = "By all";
            string str2= string.Concat(message1.TrimEnd()+" "+ message2);
            Console.WriteLine(str2);
        }
    }
}
