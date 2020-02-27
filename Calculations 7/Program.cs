using System;

namespace Calculations_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a<100 && b>200???");
            Console.WriteLine(" ");

            Console.Write("Input a first number(<100): ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Input a second number(>200): ");
            int b = int.Parse(Console.ReadLine());

            if (a < 100 && b > 200)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
