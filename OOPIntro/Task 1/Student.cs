using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

public class Student
{
    private string name;
    private string egn;
    private int[] marks;
    private int courseId;
    public Student(string name)
    {
        marks = new int[10];
        name = name;
    }

    [MaxLength(25)]
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    [StringLength(10)]
    public string EGN
    {
        get { return egn; }
        set { egn = value; }
    }

    public int[] Marks
    {
        get { return marks; }
        set { marks = value; }
    }

    public int CourseId
    {
        get 
        {
            if(courseId > 5)
            {
                return 4;
            }
            else
            {
                return 6;
            }
            return courseId * 5; 
        }
        set {
            if(value > 6)
            {
                value *= 6;
            }
            courseId = value; 
        }
    }

    public int MyProperty { get; set; }

    public DateTime GetBirthDate()
    {
        var Year = int.Parse(egn.Substring(0, 2));
        var Monnth = int.Parse(egn.Substring(2, 2));

        if (Monnth > 40)
        {
            Year += 2000;
            Monnth = Monnth - 40;
        } 
        else
        {
            Year += 1900;
        }
        var Day = int.Parse(egn.Substring(4, 2));

        DateTime date = new DateTime(Year, Monnth, Day);

        return date;
        
    }

    public double GetAge()
    {
        DateTime birthDate = GetBirthDate();

        var age = (DateTime.Now - birthDate).TotalDays/365;

        return age;
    }

    public char GetSexType()
    {
        int lastDigit = egn[egn.Length - 1];

        if (lastDigit % 2 == 0)
        {
            return 'm';
        }
        else
        {
            return 'f';
        }
    }

    public double GetAverageScore()
    {
        return marks.Average();
    }

    public bool DoesStudentHasWeakMakes()
    {
        return marks.Any(x => x < 3);
    }
}

