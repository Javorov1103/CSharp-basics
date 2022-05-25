using System;
using System.IO;
using System.Text;

namespace Task_3
{
    class Program
    {
        const string INPUT_FILE = @"D:\My Projects\CSharp-basics\Files-Exercises\resources\source.txt";
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            using (var streamReader = new StreamReader(INPUT_FILE))
            {
                int counter = 1;

                string line = streamReader.ReadLine();

                while (line != null)
                {
                    string fixedLine = $"{counter} {line}";
                    counter++;

                    sb.AppendLine(fixedLine);

                    line = streamReader.ReadLine();
                }
            }

            using (var streamWriter = new StreamWriter(INPUT_FILE))
            {
                streamWriter.WriteLine(sb);
            }
        }
    }
}
