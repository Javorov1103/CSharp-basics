using System;
using System.IO;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int equalslines = 0;
            int differentLines = 0;
            using (var streamReader = new StreamReader("path1"))
            {
                using (var streamReader2 = new StreamReader("path2"))
                {
                    var lineFromFile1 = streamReader.ReadLine();
                    var lineFromFile2 = streamReader2.ReadLine();

                    while(lineFromFile1 != null)
                    {
                        if (lineFromFile1.Equals(lineFromFile2))
                        {
                            equalslines++;
                        }
                        else
                        {
                            differentLines++;
                        }

                        lineFromFile1 = streamReader.ReadLine();
                         lineFromFile2 = streamReader2.ReadLine();
                    }

                    
                }
            }
        }
    }
}
