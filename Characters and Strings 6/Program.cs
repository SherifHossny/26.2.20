using System;

namespace Characters_and_Strings_6
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Input a Number to convert: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();

            string result = "";
            while (a > 1)
            {
                int remainder = a % 2;
                result = Convert.ToString(remainder) + result;
                a /= 2;
            }
            result = Convert.ToString(a) + result;
            Console.WriteLine("Binary: {0}", result);
        }
    }
}
