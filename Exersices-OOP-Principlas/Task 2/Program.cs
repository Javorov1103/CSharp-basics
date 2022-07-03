using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Worker worker = new Worker("Kalin","Georgiev",20);

            //Console.WriteLine(worker.WagePerHour);
            ////worker.FirstName = "Gosho";

            //Human worker2 = new Manager("Petar","Iliev",30);

            //Human student = new Student("Pencho","Penchev");

            ////worker.WorkedHours = 10;
            ////worker2.WorkedHours = 15;

            ////Console.WriteLine($"{worker.FirstName} {worker.LastName}");
            ////Console.WriteLine($"{worker2.FirstName} {worker2.LastName}");

            //List<Human> humans = new List<Human>();
            ////humans.Count = 40;

            //humans.Add(worker);
            //humans.Add(worker2);
            //humans.Add(student);

            //foreach (var human in humans)
            //{
            //    Console.WriteLine($"{human.FirstName} {human.LastName}");
            //}

            //Task 3

            //Student[] students = new Student[10];
            List<Student> students = new List<Student>();

            for (int i = 0; i <2; i++)
            {
                string firstName = Console.ReadLine();
                string lastname = Console.ReadLine();
                double mark = double.Parse(Console.ReadLine());

                Student student = new Student(firstName, lastname, mark);
                students.Add(student);
            }

           students.Sort();

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            //if(students[0].CompareTo(students[1]) > 0)
            //{
            //    Console.WriteLine();
            //}
        }
    }
}
