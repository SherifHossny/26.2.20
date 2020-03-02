using System;

namespace Condtion_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create your own calculation here");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Your first number here:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Your operator here:");
            char sth = char.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Your second number here:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();

            switch (sth)
            {
                case '+':
                    Console.WriteLine($"The result is {a + b} .");
                    break;
                
                case '-':
                    Console.WriteLine($"The result is {a - b} .");
                    break;

                case '*':
                    Console.WriteLine($"The result is {a * b} .");
                    break;   

                case '/':
                    Console.WriteLine($"The result is {a / b} .");
                    break;

                default:
                    Console.WriteLine("Please enter one of the following operators:  +  -  *  / ");
                    break;
             }

        }
    }
}
