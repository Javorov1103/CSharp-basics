using System;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Kalin");
        student.EGN = "9103118977";

        var birthDate = student.GetBirthDate();

        Console.WriteLine(student.GetAge());
        Console.WriteLine(student.GetSexType());
    }

    
}


