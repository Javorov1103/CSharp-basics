using System;
using System.Collections.Generic;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Fish goldenFish = new Fish();
            Fish blueFish = new Fish();
            GoldenFish golden = new GoldenFish();

            //Dog dog = new Dog();

            object x = new Fish();
            Fish gFish = new GoldenFish();
            Fish rFish = new RedFish();

            //List<Fish> fishes = new List<Fish>();

            //fishes.Add(gFish);
            //fishes.Add(rFish);

            //IMovable dog = new Dog();
            //IMovable fish = new Fish();

            //dog.Move();
            //fish.Move();

            Dog kuche = new Dog();
            kuche.SpeedOfRunning = 21;

            Dog kuche2 = new Dog();
            kuche2.SpeedOfRunning = 14;

            var type = typeof(Dog);
            var props = type.GetProperties();
            var fields = type.GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
           
            Console.WriteLine($"kuche e byrzo: {kuche.FastDog}");
            Console.WriteLine($"kuche2 e byrzo: {kuche2.FastDog}");

        }
    }
}
