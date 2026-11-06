using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string Name;
    public double Gpa;

    public Student(string name, double gpa)
    {
        Name = name;
        Gpa = gpa;
    }
}

class Program
{
    static void Main()
    {
        List<Student> stud = new List<Student>
        {
            new Student("Sara", 3.9),
            new Student("Ali", 3.2),
            new Student("Ahmed", 3.8),
            new Student("Ayesha", 3.5),
            new Student("Zain", 1.9)
        };

       
        var result = stud.Where(s => s.Gpa > 3.5);

        Console.WriteLine("Students with GPA > 3.5:");
        foreach (var e in result)
        {
            Console.WriteLine($"{e.Name} - {e.Gpa}");
        }

        var names = stud.Select(s => s.Name);

        Console.WriteLine("\nStudent Names:");
        foreach (var n in names)
        {
            Console.WriteLine(n);
        }

       
        var ordered = stud.OrderByDescending(s => s.Gpa);

        Console.WriteLine("\nStudents in Descending GPA Order:");
        foreach (var s in ordered)
        {
            Console.WriteLine($"{s.Name} - {s.Gpa}");
        }

       
        var topStudents = stud
            .Where(s => s.Gpa > 3.5)
            .OrderByDescending(s => s.Gpa)
            .Select(s => s.Name);

        Console.WriteLine("\nTop Students:");
        foreach (var name in topStudents)
        {
            Console.WriteLine(name);
        }

       
        var maxGpa = stud.Max(s => s.Gpa);
        Console.WriteLine($"\nMaximum GPA: {maxGpa}");

      
        var topper = stud.MaxBy(s => s.Gpa);
        Console.WriteLine($"Topper: {topper.Name} ({topper.Gpa})");

        var topperList = stud.Where(s => s.Gpa == maxGpa);

        Console.WriteLine("\nNames of Toppers:");
        foreach (var s in topperList)
        {
            Console.WriteLine(s.Name);
        }

       
        bool atRisk = stud.Any(s => s.Gpa < 2.0);
        Console.WriteLine($"\nStudent At Risk: {atRisk}");
    }
}