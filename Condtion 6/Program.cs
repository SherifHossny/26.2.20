using System;

namespace Condtion_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number to day of the week");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Your number here:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            switch (a)
            {
                case 1:
                    Console.WriteLine($"Monday");
                    break;

                case 2:
                    Console.WriteLine($"Tuesday");
                    break;

                case 3:
                    Console.WriteLine($"Wednesday");
                    break;

                case 4:
                    Console.WriteLine($"Thursday");
                    break;

                case 5:
                    Console.WriteLine($"Friday");
                    break;

                case 6:
                    Console.WriteLine($"Saturday");
                    break;

                case 7:
                    Console.WriteLine($"Sunday");
                    break;

                default:
                    Console.WriteLine("Nice try but my week has only SEVEN days.");
                    break;
            }
            }
    }
}
