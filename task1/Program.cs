using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("Example 1");
                Console.WriteLine(" ");
                Console.WriteLine("a+b*c");

                Console.Write("a= ");
                var a = int.Parse(Console.ReadLine());

                Console.Write("b= ");
                var b = int.Parse(Console.ReadLine());

                Console.Write("c= ");
                var c = int.Parse(Console.ReadLine());

                Console.WriteLine(a + b * c);
                Console.WriteLine(" ");
            }

            {
                Console.WriteLine("Example 2");
                Console.WriteLine(" ");
                Console.WriteLine("(a+b)%c");

                Console.Write("a= ");
                var a = int.Parse(Console.ReadLine());

                Console.Write("b= ");
                var b = int.Parse(Console.ReadLine());

                Console.Write("c= ");
                var c = int.Parse(Console.ReadLine());

                Console.WriteLine((a + b) % c);
                Console.WriteLine(" ");
            }

            {
                Console.WriteLine("Example 3");
                Console.WriteLine(" ");
                Console.WriteLine("a + b * c / d");

                Console.Write("a= ");
                var a = int.Parse(Console.ReadLine());

                Console.Write("b= ");
                var b = int.Parse(Console.ReadLine());

                Console.Write("c= ");
                var c = int.Parse(Console.ReadLine());

                Console.Write("d= ");
                var d = int.Parse(Console.ReadLine());

                Console.WriteLine(a + b * c / d);
                Console.WriteLine(" ");
            }
            {
                Console.WriteLine("Example 4");
                Console.WriteLine(" ");
                Console.WriteLine("a + b / c * d - e % f");

                Console.Write("a= ");
                var a = int.Parse(Console.ReadLine());

                Console.Write("b= ");
                var b = int.Parse(Console.ReadLine());

                Console.Write("c= ");
                var c = int.Parse(Console.ReadLine());

                Console.Write("d= ");
                var d = int.Parse(Console.ReadLine());

                Console.Write("e= ");
                var e = int.Parse(Console.ReadLine());

                Console.Write("f= ");
                var f = int.Parse(Console.ReadLine());

                Console.WriteLine(a + b / c * d - e % f);
            }




        }
    }
}
