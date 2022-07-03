using System;
using System.Collections.Generic;
using Task_5;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Frog frog = new Frog("Kermit", 2, "male");
            Cat cat = new Cat("Tom", 4, "male");
            Dog dog = new Dog("Roxan", 3, "female");

            List<Animal> animals = new List<Animal>();
            animals.Add(frog);
            animals.Add(cat);
            animals.Add(dog);

            foreach (var animail in animals)
            {
                Console.WriteLine(animail.Sound());
            }
       
            

        }
    }
}
