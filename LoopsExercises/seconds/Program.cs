using System;
using System.Globalization;
using System.Threading;

namespace seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int sumOfSeconds = a + b + c;

            int minutes = sumOfSeconds / 60;

            int restSeconds = sumOfSeconds % 60;

            Console.WriteLine($"{minutes}:{restSeconds}");

            //Console.WriteLine($"Mins: {minutes}");
            //Console.WriteLine($"Seconds: {restSeconds}");
        }
    }
}
