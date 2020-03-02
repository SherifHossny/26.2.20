using System;

namespace Condtion_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is it 20?");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("First number here:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Second number here:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();

            int c = a + b;

            if (a == 20 | b == 20 | c == 20)
            {
                Console.WriteLine("We have a winner!");
            }
            else
                Console.WriteLine("Try again");
        }
    }
}
