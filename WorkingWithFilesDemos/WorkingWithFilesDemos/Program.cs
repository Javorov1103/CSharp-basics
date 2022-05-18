using System;
using System.IO;
using System.Text;

namespace WorkingWithFilesDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var reader = new StreamReader(@"D:\test\test.txt"))
            //{
            //    var firstLine = reader.ReadLine();
            //}

            //using (var writer = new StreamWriter(@"D:\test\test.txt", true))
            //{
            //    writer.WriteLine(" new text 2");
            //}
            //StringBuilder builder = new StringBuilder();

            //using (var streamReader = new StreamReader(@"D:\test\test.txt"))
            //{
            //    int lineNumer = 0;

            //    string line = streamReader.ReadLine();

            //    while (line != null)
            //    {
            //        lineNumer++;
            //        //Console.WriteLine($"Line {lineNumer}: {line}");

            //        builder.AppendLine(line);


            //        line = streamReader.ReadLine();
            //    }
            //}

            //Console.WriteLine(builder);

            //Sending email


            //string[] lines = File.ReadAllLines(@"D:\test\test.txt");

            //string text = File.ReadAllText(@"D:\test\test.txt");

            //using (var stream = File.Create(@"D:\test\new_file.txt"))
            //{
            //    stream.Write(Encoding.ASCII.GetBytes("Hello"));
            //}
            //var stream = new StreamReader()
            File.Copy(@"D:\test\new_file.txt", @"D:\test\new_file2.txt");
        }
    }
}
