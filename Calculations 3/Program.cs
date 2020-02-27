using System;

namespace Calculations_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(" ");
            Console.WriteLine("a * b * c");
            Console.WriteLine(" ");

            Console.Write("Input the first number to multiply: ");
            var a = int.Parse(Console.ReadLine());

            Console.Write("Input the second number to multiply: ");
            var b = int.Parse(Console.ReadLine());

            Console.Write("Input the third number to multiply: ");
            var c = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine($"{a} x {b} x {c} = {a * b * c} ");
        }
    }
    
}
