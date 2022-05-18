using System;

namespace DemoMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read from console
            int n = int.Parse(Console.ReadLine());

            //Business logic
            int res = SumNumbers(n);

            //Write on Console
            Console.WriteLine(res);

        }
        public static int SumNumbers(int number)
        {
            int result = 0;

            for (int i = 1; i <= number; i++)
            {
                result += i;
            }

            return result;
        }

    }

   
}
