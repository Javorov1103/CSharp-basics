using System;
using System.IO;

namespace Task_1._1
{
    class Program
    {
        const string INPUT_FILE = @"D:\My Projects\CSharp-basics\Files-Exercises\resources\source.txt";
        static void Main(string[] args)
        {
            using (var streamReader = new StreamReader(INPUT_FILE))
            {
                int counter = 1;
                
                string line = string.Empty;
                while ((line = streamReader.ReadLine()) != null)
                {
                    if (counter % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }

                    counter++;
                }
            }
        }
    }
}
