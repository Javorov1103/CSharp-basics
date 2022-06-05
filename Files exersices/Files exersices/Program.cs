using System;
using System.IO;
using System.Linq;

namespace Files_exersices
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var streamReader = new StreamReader("path to file"))
            {
                string firstLine = streamReader.ReadLine();

                int matrixSize = int.Parse(firstLine);

                //int[,] matrix = new int[3, 3];

                int[][] matrix = new int[matrixSize][];

                string line = streamReader.ReadLine();
                int counter = 0;
                while (line != null)
                {
                    var numbers = line
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => int.Parse(x)).ToArray();

                    matrix[counter] = numbers;
                    counter++;
                }
            }
        }
    }
}
