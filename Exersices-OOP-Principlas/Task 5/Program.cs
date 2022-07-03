using System;
using System.Collections.Generic;
using Task_5;

class Program
{
    static void Main(string[] args)
    {
        Triangle triangle = new Triangle(3, 4);
        Rectangle rectangle = new Rectangle(5, 2);
       
        Circle circle = new Circle(7);

        List<Shape> shapes = new List<Shape>();
        
        shapes.Add(triangle);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (var shape in shapes)
        {
            Console.WriteLine(shape.CalculateSurface());
        }

    }
}

