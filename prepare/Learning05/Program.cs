using System;

class Program
{
    static void Main(string[] args)
    {
        
        MathAssignment a = new ("7.3", "3-10, 20-21", "Samuel", "Multiplication");

        Console.WriteLine(a.GetSummary());
        Console.WriteLine(a.GetHomeworkList());

        WritingAssignment w = new ("The Causes of World War II", "Samuel", "Multiplication");

        Console.WriteLine(w.GetSummary());
        Console.WriteLine(w.GetWritingInformation());
    }
}