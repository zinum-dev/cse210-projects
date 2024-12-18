using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

        List<Activity> activities= [];
        Running running= new (new DateTime(2024, 11, 3),30,4.8);
        activities.Add(running);
        
        Cycling cycling = new (new DateTime(2024, 11, 4),20,3.5);
        activities.Add(cycling);
        
        Swimming swimming = new (new DateTime(2024, 11, 5),10,15);
        activities.Add(swimming);


        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            
        }
    }
}