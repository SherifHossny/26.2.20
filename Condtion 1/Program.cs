using System;

namespace Condtion_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Is the first one negative and the second one positive?");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("First number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(); 
            Console.WriteLine();
            Console.Write("Second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            if (a < 0 && b > 0)
            {
                Console.WriteLine("Yes the first one is Negative and the second is Positive.");
            }
            else{
                Console.WriteLine("The numbers that you provided did not pass the test");
            }

        }
    }
}
