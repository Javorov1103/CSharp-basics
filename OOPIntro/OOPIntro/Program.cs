using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OOPIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person pesho = new Person();
            //Person kalin = new Person("Kalin Georgiev", 30);

            //pesho.Name = "Petyr Stoyqnov";
            //pesho.Age = 28;

            //Console.WriteLine($"We have two persons. First person name is {pesho.Name}, second person's name is {kalin.Name}");

            //List<int> myNums = new List<int>();
            //myNums.Add(4);
            //myNums.Add(5);
            //myNums.Add(6);
            //myNums.Add(7);

            //var count = myNums.Count;

            //Student student1 = new Student("Kalin");

            //reading data from database

            //student1.MathMarks = new List<int>() { 4, 5, 6, 2, 3 };

            //var averageMathMark = student1.MathMarks.Sum() / student1.MathMarks.Count;

            //Console.WriteLine($"Student {student1.Name} will finish the year " +
            //    $"with {averageMathMark} for Maths");

            //Person person1 = new Person();
            //person1.Name = "Gosho";
            //person1.Age = 28;

            //if (person1.Age > 18)
            //{
            //    person1.PersonCar = new Car();
            //    person1.PersonCar.StartEngine();
            //}

            List<Student> students = new List<Student>();

            using (var reader = new StreamReader(@"D:\My Projects\CSharp-basics\OOPIntro\OOPIntro\students.txt"))
            {
                for (int i = 0; i < 10; i++)
                {
                    Student currentStudent = new Student();
                    currentStudent.Name = reader.ReadLine();
                    currentStudent.Age = int.Parse(reader.ReadLine());
                    currentStudent.Address = reader.ReadLine();
                    currentStudent.MathMarks = reader
                        .ReadLine()
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => int.Parse(x))
                        .ToList();
                    currentStudent.BioMarks = reader
                        .ReadLine()
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => int.Parse(x))
                        .ToList();

                    students.Add(currentStudent);
                }
            }


        }
    }

    class Person
    {
        #region Fields
        private int age;
        private string name;
        #endregion
        #region Constructors
        public Person()
        {

        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int Age
        {
            get { return age; }

            set { age = value; }
        }

        public Car PersonCar { get; set; }
        #endregion
    }

    class Student
    {
        private string name;
        private string address;
        private List<int> bioMarks;

        public Student()
        {

        }

        public Student(string name)
        {
            Name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age { get; set; }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private List<int> mathMarks;

        public List<int> MathMarks
        {
            get { return mathMarks; }
            set { mathMarks = value; }
        }

       

        public List<int> BioMarks
        {
            get { return bioMarks; }
            set { bioMarks = value; }
        }

    }

    class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public void StartEngine()
        {
            Console.WriteLine("Starting the engine");
        }
    }

}
