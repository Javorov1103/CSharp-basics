using System;
using System.Text.RegularExpressions;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Some text";
            string text2 = "some text";
            //Indexing
            char firstChar = text[0];

            //Looping
            //foreach (var element in text)
            //{
            //    Console.WriteLine((int)element);
            //}

            //Comparing
            //Console.WriteLine(text == text2);

            //Console.WriteLine(text == text2);
            //Console.WriteLine(text.Equals(text2));

            //Methods
            //var newString = text.Replace('t', 'a');
            //Console.WriteLine(newString);

            //var newString2 = text.Replace("text", "shock");
            //Console.WriteLine(newString2);

            //var substringText = text.Substring(5);
            //Console.WriteLine(substringText);

            //var substringText2 = text.Substring(5, 2);
            //Console.WriteLine(substringText2);

            //var removed = text.Remove(5);
            //Console.WriteLine(removed);

            //var textToBeRemoved = text.Substring(5);
            //var removed2 = text.Replace(textToBeRemoved, string.Empty);
            //Console.WriteLine(removed2);

            //string example = null;
            //string example2 = string.Empty;

            //for (int i = 0; i < example2.Length; i++)
            //{
            //    Console.WriteLine(example[i]);
            //}

          


            //Printing
            //var someText = Console.ReadLine();

            //Console.WriteLine("some text to print");
            //Console.WriteLine(5);

            string name = "Kalin";
            int age = 31;
            string address = "Ruse, Antim 1";

            //Interpolation
            Console.WriteLine($"My name is {name}. I am {age} years old. my address is: {address}");

            string formattedText2 = $"My name is {name}. I am {age} years old. my address is: {address}";

            Console.WriteLine("My name is {0}. I am {1} years old. my address is: {2}", name, age, address);

            string formattedtext = string.Format("My name is {0}. I am {1} years old. my address is: {2}", name, age, address);

            Console.WriteLine("My name is" + name+ ". I am " + age + " years old. my address is:" + address);

            Regex regex = new Regex("^[a-zA-Z]{8,15}$");

           var valid =  regex.IsMatch("KalinGeorgiev");

            Console.WriteLine();


        }
    }
}
