using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Въвеждане на информация
            Console.WriteLine("Моля въведете първо име:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Моля въведете презиме:");
            string secondName = Console.ReadLine();

            Console.WriteLine("Моля въведете фамилия:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Въведете адрес");
            string address = Console.ReadLine();

            Console.WriteLine("Въведете години");
            int age = int.Parse(Console.ReadLine());

            Dictionary<string, int[]> marks = new Dictionary<string, int[]>();

            //int[] mathMarks = new int[4];
            //int[] historyMarks = new int[4];
            //int[] bioMarks = new int[4];
            int[] chemistryMarks2 = new int[4];
            List<int> mathMarks = new List<int>();
            List<int> historyMarks = new List<int>();
            List<int> bioMarks = new List<int>();
            List<int> chemistryMarks = new List<int>();

            Console.WriteLine("Колко оценки по математика има студента.");

            int numberOfMarks = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfMarks; i++)
            {
                mathMarks.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Въведете 4 оценки по история");
            for (int i = 0; i < 4; i++)
            {
                historyMarks.Add(int.Parse(Console.ReadLine()));
                //historyMarks[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Въведете 4 оценки по биология");
            for (int i = 0; i < 4; i++)
            {
                bioMarks[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Въведете 4 оценки по химия");
            for (int i = 0; i < 4; i++)
            {
                chemistryMarks[i] = int.Parse(Console.ReadLine());
            }
            #endregion

            #region Бизнес логика
            string command = GetCommand();

            while (command != "exit")
            {
                switch (command)
                {
                    case "info":
                        PrintStudentInfo(firstName, secondName, lastName, address, age);
                        break;
                    case "average":
                        //GetAverageMarks(mathMarks, historyMarks, bioMarks, chemistryMarks);
                        break;
                    case "average 1":
                        Console.WriteLine("средна оценка за предмент 1");
                        break;
                    case "average 2":
                        Console.WriteLine("средна оценка за предмент 2");
                        break;
                    case "average 3":
                        Console.WriteLine("средна оценка за предмент 3");
                        break;
                    case "average 4":
                        Console.WriteLine("средна оценка за предмент 4");
                        break;
                    default:
                        Console.WriteLine("Непозната команда");
                        break;
                }

                //if(command == "info")
                //{
                //    PrintStudentInfo(firstName, secondName, lastName, address, age);
                //}
                //else if(command == "average")
                //{
                //    GetAverageMarks(mathMarks, historyMarks, bioMarks, chemistryMarks);
                //}

                command = GetCommand();
            }
            #endregion

            Console.WriteLine("Край");

        }

        private static void PrintStudentInfo(string firstName, string secondName, string lastName, string address, int age)
        {
            Console.WriteLine($"Аз съм {firstName} {secondName} {lastName}. Живея на {address}. И съм на {age} години.");
        }

        static string GetCommand()
        {
            Console.WriteLine("Моля въведете команда");

            return Console.ReadLine();
        }

        static void GetAverageMarks(int[] mathMarks, int[] historyMarks, int[] bioMarks, int[] chemistryMarks)
        {
            double average = 0;

            average += mathMarks.Sum();
            average += historyMarks.Sum();
            average += bioMarks.Sum();
            average += chemistryMarks.Sum();

            //for (int i = 0; i < 4; i++)
            //{
            //    average += mathMarks[i];
            //    average += historyMarks[i];
            //    average += bioMarks[i];
            //    average += chemistryMarks[i];
            //}

            average = average / 16;

            Console.WriteLine($"Средната оценка на студента е {average}");
        }
    }
}
