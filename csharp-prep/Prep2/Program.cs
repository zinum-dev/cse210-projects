using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        int gradePercentage = int.Parse(Console.ReadLine());

        string letter;

        if( gradePercentage >= 90) 
        {
            letter = "A";
        }
        else if ( gradePercentage >= 80) 
        {
            letter = "B";
        }
        else if ( gradePercentage >= 70) 
        {
            letter = "C";
        }
        else if ( gradePercentage >= 60) 
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        Console.WriteLine(letter);


         if ( gradePercentage >= 70 )
         {
            Console.WriteLine("Congratulations, you passed the course!");
         }
         else
         {
            Console.WriteLine("Unfortunately, you didn't pass this time, but you can try again.");
         }

    }
}