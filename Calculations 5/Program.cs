using System;

namespace Calculations_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thermometer converter");
            Console.WriteLine(" ");

            Console.Write("Enter the amount of celsius: ");
            int celsius = int.Parse(Console.ReadLine());

            Console.WriteLine($"Kelvin = {celsius + 273}");
            Console.WriteLine($"Fahrenheit = {celsius * 18 / 10 + 32}");
        }
    }
}
