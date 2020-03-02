using System;

namespace Condtion_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is it within 20 of 100 or 200?");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Your number here:");
            int a = int.Parse(Console.ReadLine());

            if(Math.Abs(a - 100) <=20 | Math.Abs(a - 200) <= 20)
            {
                Console.WriteLine("$ {a} is within 20 of 100 or 200." );                
            }
            else
                Console.WriteLine("$ {a} is NOT within 20 of 100 or 200.");
        }
    }
}
