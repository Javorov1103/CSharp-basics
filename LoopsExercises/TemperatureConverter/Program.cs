using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your body temp in Farenh");

        double temp = double.Parse(Console.ReadLine());

        temp = ConvertFahrenheitToCelsius(temp);

        Console.WriteLine($"Your body temp in Celsius degrees is {temp}");

        if(temp > 37)
        {
            Console.WriteLine("You are ill!");
        }
    }

    public static double ConvertFahrenheitToCelsius(double tempF)
    {
        double tempC = (tempF - 32) * 5 / 9;

        return tempC;
    }
}

