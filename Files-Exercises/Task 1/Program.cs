namespace Task_1
{
    using System;
    using System.IO;

    class MyClass
    {
        const double COEFFICIENT = 1.05;
        const int ADDITION = 5000;
        const string INPUT_FILE = @"D:\My Projects\CSharp-basics\Files-Exercises\resources\source.txt";
        const string OUTPUT_FILE = @"D:\My Projects\CSharp-basics\Files-Exercises\resources\fixed.txt";

        static void Main(string[] args)
        {
            //Task 6 from strings


            //string text = "http://www.devbg.org/forum/index.php";

            //var elements = text.Split(new char[] { ':', '/' }, StringSplitOptions.RemoveEmptyEntries);

            //string protocol = elements[0];
            //string server = elements[1];
            //string resource = string.Empty;

            //for (int i = 2; i < elements.Length; i++)
            //{
            //    resource += $"/{elements[i]}";
            //}

            //Console.WriteLine(protocol);
            //Console.WriteLine(server);
            //Console.WriteLine(resource);

           

            try
            {
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                // Getting the Cyrillic encoding
                System.Text.Encoding encoding =
                      System.Text.Encoding.GetEncoding(1251);

                // Create reader with the Cyrillic encoding
                StreamReader streamReader =
                      new StreamReader(INPUT_FILE, encoding);

                // Create writer with the Cyrillic encoding
                StreamWriter streamWriter =
                      new StreamWriter(OUTPUT_FILE, false, encoding);

                using (streamReader)
                {
                    using (streamWriter)
                    {
                        string line;
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            string fixedLine = FixLine(line);
                            streamWriter.WriteLine(fixedLine);
                        }
                    }
                }
            }
            catch (IOException exc)
            {
                Console.WriteLine("Error: {0}.", exc.Message);
            }
        }

        static string FixLine(string line)
        {
            //{1029}{1122}{Y:i}Капитане, системите са|в готовност.
            // Find closing brace
            int bracketFromIndex = line.IndexOf('}');

            // Extract 'from' time
            string fromTime = line.Substring(1, bracketFromIndex - 1);

            // Calculate new 'from' time
            int newFromTime = (int)(Convert.ToInt32(fromTime) *
                  COEFFICIENT + ADDITION);

            // Find the following closing brace
            int bracketToIndex = line.IndexOf('}',
                  bracketFromIndex + 1);

            // Extract 'to' time
            string toTime = line.Substring(bracketFromIndex + 2,
                  bracketToIndex - bracketFromIndex - 2);

            // Calculate new 'to' time
            int newToTime = (int)(Convert.ToInt32(toTime) *
                  COEFFICIENT + ADDITION);

            // Create a new line using the new 'from' and 'to' times
            string fixedLine = "{" + newFromTime + "}" + "{" +
                  newToTime + "}" + line.Substring(bracketToIndex + 1);

            return fixedLine;
        }
    }
}

