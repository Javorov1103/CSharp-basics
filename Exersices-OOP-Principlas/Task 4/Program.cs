using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "hello world";

            Console.WriteLine(text);

            Person person = new Person();
            person.Name = "Kalin";
            person.Age = 31;

            Console.WriteLine(person);
        }
    }

    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} is {Age} years old";
        }
    }
}
