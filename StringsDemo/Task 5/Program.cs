using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string forbidenWords = "C#, CLR, Microsoft-NovaDuma@test";

            string[] words = forbidenWords.Split(new char[] { ',',' ','-','@' }, StringSplitOptions.RemoveEmptyEntries);

            string text = "Microsoft announced its next generation C# compiler today. It uses advanced parser and special optimizer for the Microsoft CLR.";

            foreach (var x in words)
            {
                int lenght = x.Length;
                text = text.Replace(x, "*");
            }

            Console.WriteLine(text);


        }
    }
}
