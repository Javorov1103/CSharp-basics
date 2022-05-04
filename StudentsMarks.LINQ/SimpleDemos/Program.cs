
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var studentMarks = new Dictionary<string, double>();

        studentMarks["Pesho"] = 3.00;
        studentMarks["Mariq"] =  3.50;
        studentMarks["Gosho"] =  3.50;
        studentMarks["Sasho"] = 3.50;


        studentMarks.Add("Kalin", 2.00);

        //bool success = studentMarks.Remove("Kalin");
        //success = studentMarks.Remove("Gergana");

        //double peshoValue;
        //success = studentMarks.Remove("Pesho", out peshoValue);


        studentMarks["Sasho"] = 6.00;

        foreach (var kvp in studentMarks)
        {
            Console.WriteLine($"{kvp.Key} - {kvp.Value}");
        }

        if(studentMarks.ContainsKey("Stavri"))
        {
            var elemnt = studentMarks["Stavri"];
            //business logic
        }

        var keys = studentMarks.Keys;



        //Console.WriteLine($"Pesho's mark: {studentMarks["Pesho"]:0.00}");
        var person = new Peson() { Age = 30, Name = "Kalin" };
        var person2 = new Peson() { Age = 32, Name = "Sasho" };

        SortedDictionary<Peson, double> sortedDic = new SortedDictionary<Peson, double>();

        sortedDic.Add(person, 2);
        sortedDic.Add(person2, 2);

        var table = new Table();

        table.Color = "white";
        table.NumberOfLegs = 4;
        table.Height = 75.6;

        
    }
}

class Peson
{
    public int Age { get; set; }

    public string Name { get; set; }

    public string Address { get; set; }

    public Peson[] Children { get; set; }

}

class Table
{
    public string Color { get; set; }

    public int NumberOfLegs { get; set; }

    public double Height { get; set; }
}

