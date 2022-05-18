using System;
using System.Collections.Generic;
using System.Text;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.WriteLine(list);
            StringBuilder builder = new StringBuilder();

            builder.Append("Hello. ");
            builder.AppendLine("My name is Kalin");
            builder.AppendLine("new row");

            Console.WriteLine(builder);

            string text = builder.ToString();

            builder.Clear();

            //string text = "Hello.";
            //text += " My name is Kalin";
            //text += " \nnew row";

            //Console.WriteLine(text);
        }
    }
}
