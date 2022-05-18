using System;

namespace ArraysDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[5];

            //numbers[0] = 3;
            //numbers[1] = 4;
            //numbers[2] = 6;
            //numbers[3] = 20;
            //numbers[4] = 100;

            int[] djob1 = new int[] { 5, 10, 20, 50, 100, 1 };

            string[] textArray = new string[] { "Pyrva", "Vtori", "Treti", "Chetvyrti" };

            //Console.WriteLine(djob1[2]);

            //Console.WriteLine(djob1.Length);

            //Console.WriteLine(djob1[djob1.Length - 1]);

            //-----------------------------------------------------



            //ReversedArray Example
            //Console.WriteLine("Please give me the size of the array");

            //int lenght = int.Parse(Console.ReadLine());

            //int[] array = new int[lenght];

            ////Filling the original array
            //for (int i = 0; i < lenght; i++)
            //{
            //    Console.WriteLine("Give me number for index: " + i);
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //int[] reversed = new int[lenght];

            ////Reversing the array, filling the reversed array
            //for (int i = 0; i < lenght; i++)
            //{
            //    int currElement = array[i];
            //    reversed[lenght - 1-i] = currElement;
            //}

            //Console.WriteLine("This is the original array");
            ////Printing the original array
            //for (int i = 0; i < lenght; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}

            //Console.WriteLine();

            //Console.WriteLine("This is the reversed array");
            ////Printing the reversed array
            //for (int i = 0; i < lenght; i++)
            //{
            //    Console.Write(reversed[i] + " ");
            //}

            for (int i = 0; i < textArray.Length; i++)
            {
                Console.WriteLine(textArray[i]);
            }

            foreach (var word in textArray)
            {
                Console.WriteLine(word);
            }
        }
    }
}
