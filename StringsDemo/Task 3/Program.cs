using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

            int index1 = text.IndexOf("<upcase>");

            int index2 = text.IndexOf("</upcase>");

            string substring = text.Substring(index1 + 8, index2 - index1-8);

            text = text.Replace(substring, substring.ToUpper());
        }
    }
}
