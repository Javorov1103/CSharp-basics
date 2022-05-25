using System;
using System.IO;
using System.Text;

namespace Task_2
{
    class Program
    {
        const string INPUT_FILE = @"D:\My Projects\CSharp-basics\Files-Exercises\resources\source.txt";
        const string INPUT_FILE2 = @"D:\My Projects\CSharp-basics\Files-Exercises\resources\fixed.txt";
        const string OUTPUT_FILE = @"D:\My Projects\CSharp-basics\Files-Exercises\resources\result.txt";

        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();


            //Read from first file
            using (var streamReader = new StreamReader(INPUT_FILE))
            {
                string line = string.Empty;

                while ((line = streamReader.ReadLine()) != null)
                {
                    sb.AppendLine(line);
                }
            }
            //Read from second file
            using (var streamReader = new StreamReader(INPUT_FILE2))
            {
                string line = string.Empty;

                while ((line = streamReader.ReadLine()) != null)
                {
                    sb.AppendLine(line);
                }
            }
            //Write int output file
            using (var streamWriter = new StreamWriter(OUTPUT_FILE))
            {
                streamWriter.WriteLine(sb);
            }
        }
    }
}
