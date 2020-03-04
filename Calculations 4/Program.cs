using System;

namespace Calculations_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ");
            Console.WriteLine("The average of numbers");
            Console.WriteLine(" ");

            Console.Write("Enter the First number: ");
            var a = int.Parse(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            var b = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            var c = int.Parse(Console.ReadLine());

            Console.Write("Enter the fourth number: ");
            var d = int.Parse(Console.ReadLine());
                        
            Console.WriteLine("");
            Console.WriteLine($"The average of {a}, {b}, {c}, {d} is {(a+b+c+d)/4}");
        }
    }
}
