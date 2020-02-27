using System;

namespace _26._2._20b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculating the surface and volume of the sphere");
            Console.WriteLine();
            Console.Write("Enter the radius of the sphere in centimeters here: ");
            double r = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            if (r > 0)
            {
                Console.WriteLine($"The Surface Area of the Sphere is {System.Math.Round((4.0 * Math.PI * (Math.Pow(r, 2))), 5)} square centimeters. ");

                Console.WriteLine();

                Console.WriteLine($"The Volume of the Sphere is {System.Math.Round((4.0 / 3) * Math.PI * (Math.Pow(r,3)), 5)} cubic centimeters. ");
            }

            else
            {
                {
                    Console.WriteLine($"The Radius needs to be more than zero. Please try again! ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
