using System;

namespace Calculations_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Var swap");
            Console.WriteLine(" ");


            Console.Write("a= ");
            var a = int.Parse(Console.ReadLine());

            Console.Write("b= ");
            var b = int.Parse(Console.ReadLine());

            int c = a;
            a = b;
            b = c;


            Console.WriteLine($"a's new value is {a} and b's new value is {b}");
            Console.WriteLine(" ");
        }
    }
    
}
