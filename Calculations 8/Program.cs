using System;

namespace Calculations_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LARGEST and lowest");
            Console.WriteLine(" ");
            
            Console.Write("Input first integer: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Input second integer: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Input first integer: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            int small = Int32.MinValue;
            int big = Int32.MaxValue;

            if (a >= b && a >=c)
            {
                big = a;                
            }
            else if(b >= a && b >= c)
            {
                big = b;
            }
            else
            {
                big = c;
            }

            if(a<= b && a <= c)
            {
                small = a;
            }
            else if (b <= a && b <= c)
            {
                small = b;
            }

            if (big != small)
            {
                Console.WriteLine($"The largest of the three numbers is {big} ");
                Console.WriteLine(" ");
                Console.WriteLine($"The lowest of the three numbers is {small} ");
            }
            else
            {
                Console.WriteLine($"All the numbers you have typed are the same number and it is: {small} ");

            }
        }
    }
}
