using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "introduction";

            string reverse = string.Empty;

            //int lastIndex = word.Length - 1;

            //while (lastIndex >=0)
            //{
            //    reverse += word[lastIndex];

            //    lastIndex--;
            //}

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse += word[i];
            }
        }
    }
}
