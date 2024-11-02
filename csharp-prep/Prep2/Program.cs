using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        int gradePercentage = int.Parse(Console.ReadLine());


        // Grade Scale:
        // A >= 90
        // B >= 80
        // C >= 70
        // D >= 60
        // F < 60
        if( gradePercentage >= 90) 
        {
            Console.WriteLine("A");
        }
        else if ( gradePercentage >= 80) 
        {
            Console.WriteLine("B");
        }
        else if ( gradePercentage >= 70) 
        {
            Console.WriteLine("C");
        }
        else if ( gradePercentage >= 60) 
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }

    }
}