using System;

namespace AreaOfTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintGreeting();

            int a = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double area = CalculateAreaOfTriangle(a, h);

            Console.WriteLine(area);

        }

        private static void PrintGreeting()
        {
            Console.WriteLine("Hello student");
            Console.WriteLine("How are you today");
            Console.WriteLine("Give me 2 numbers and I will calc the area of triangle for you");
        }

        private static double CalculateAreaOfTriangle(int a, int h)
        {
            double result = a * h / 2;

            return result;
        }
    }
}
