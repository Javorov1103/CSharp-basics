using System;
using System.IO;

namespace demo
{
    class Program
    {
        const string NAME = "path to the file";
        static void Main(string[] args)
        {
            File.Delete(NAME);
        }
    }
}
