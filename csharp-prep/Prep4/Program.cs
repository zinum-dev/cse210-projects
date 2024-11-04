using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numList = new List<int>();
        int num = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (num != 0)
        {
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            if (num != 0)
            {
                numList.Add(num);
            }
        }

        int sum = numList.Sum();
        Console.WriteLine($"The sum is: {sum}");

        double average = numList.Average();
        Console.WriteLine($"The average is: {average}");

        int max = numList.Max();
        Console.WriteLine($"The largest is: {max}");

        numList.Sort();
        Console.WriteLine("The sorted list is: [" + string.Join(", ", numList) + "]");

       }
}