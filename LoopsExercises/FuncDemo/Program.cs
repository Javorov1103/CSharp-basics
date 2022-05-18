using System;

namespace FuncDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //double strana = double.Parse(Console.ReadLine());
            //double visochina = double.Parse(Console.ReadLine());

            //double areaOfTriangle = CalculateAreaOfTriangle(strana, visochina);

            //double strana2 = double.Parse(Console.ReadLine());
            //double visochina2 = double.Parse(Console.ReadLine());

            //double areaOfTriangle2 = CalculateAreaOfTriangle(strana2, visochina2);

            int snakeX=2;
            int snakeY=2;

            while((snakeX >= 0 && snakeX<=4) && (snakeY>=0 && snakeY<=4))
            {

            }
        }

      public static double CalculateAreaOfTriangle(double a, double h)
        {
            double area = a * h / 2;

            return area;
        }
    }

   
}
