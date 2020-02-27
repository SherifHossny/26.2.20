using System;

namespace Calculations_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am a multiple of 7 or 3.");
            Console.WriteLine(" ");

            Console.Write("Enter number here: ");
            int a = int.Parse(Console.ReadLine());

            if (a%3 == 0 | a%7 == 0)
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
