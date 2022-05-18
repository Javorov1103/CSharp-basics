using System;

namespace Factorial
{
    class Program
    {
        static void Main()
        {
            Console.Write("n = ");

            int n = int.Parse(Console.ReadLine());

            decimal factorial = Factorial(n);

            Console.WriteLine("{0}! = {1}", n, factorial);
        }

        static decimal Factorial(int n)
        {
            // The bottom of the recursio
            if (n == 0)
            {
                return 1;
            }

            // Recursive call: the method calls itself
            else
            {
                int nextNumber = n - 1;
                return n * Factorial(nextNumber);
            }

        }
    }
}
