using System;

namespace Calculations_11
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine();
            Console.Write("Determine in which quadrant the coordinate point lies");
            Console.WriteLine();
            Console.WriteLine();


            Console.Write("Input the value for X coordinate :");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Input the value for Y coordinate :");
            int y = int.Parse(Console.ReadLine());


            if (x > 0 && y > 0)
                Console.WriteLine($"The coordinate point ({x} {y}) lies in the First quandrant.");

            else if (x < 0 && y > 0)
                Console.WriteLine($"The coordinate point ({x} {y}) lies in the Second quandrant." );

            else if (x < 0 && y < 0)
                Console.WriteLine($"The coordinate point ({x} {y}) lies in the Third quandrant." );

            else if (x > 0 && y < 0)
                Console.WriteLine($"The coordinate point ({x} {y}) lies in the Fourth quandrant.");
            
            else if (x > 0 && y == 0)
                Console.WriteLine($"The coordinate point ({x} {y}) lies between the First and the Fourth quandrant.");
            
            else if (x == 0 && y < 0)
                Console.WriteLine($"The coordinate point ({x} {y}) lies between the Third and the Fourth quandrant.");
            
            else if (x == 0 && y > 0)
                Console.WriteLine($"The coordinate point ({x} {y}) lies between the First and the Second quandrant.");
            
            else if (x < 0 && y == 0)
                Console.WriteLine($"The coordinate point ({x} {y}) lies between the Second and the Third quandrant.");

            else if (x == 0 && y == 0)
                Console.WriteLine($"The coordinate point ({x} {y}) lies at the origin." );
        }
    }
}
