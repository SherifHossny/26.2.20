using System;

namespace Calculations_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Centuries");
            Console.WriteLine(" ");

            Console.Write("Year: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            if (a >= 0)
            {
                int b = a / 100 + 1;
                Console.WriteLine($"This year is during the {b} century AD.");
            }
            else
            {
                int b = a / -100 + 1;
                Console.WriteLine($"This year is during the {b} century BC.");
            }



        }
    }
}
