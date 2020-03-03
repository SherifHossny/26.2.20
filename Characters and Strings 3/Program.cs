using System;
using System.Collections.Generic;

namespace Characters_and_Strings_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse the string");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Your string here:");
            
            List<char> newList = new List<char>();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            string yourString = Console.ReadLine();

            for(int a = (yourString.Length-1); a > -1; a--)
            {
                newList.Add(yourString[a]);
                //newList.Add(yourString[a]);
            }
            
            Console.WriteLine(newList.ToString());


        }
    }
}
