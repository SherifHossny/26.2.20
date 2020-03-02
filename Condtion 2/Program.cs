using System;

namespace Condtion_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ABS");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("First number here:");
            int a= int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("First number here:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();            
            int c = (a-b);

            if (a > b)
            {
                Console.WriteLine(Math.Abs(c*2));
            }
            else
                Console.WriteLine(Math.Abs(c));

        }
    }
}
