using System;

class Program
{
    static void Main(string[] args)
    {

        int option = 0;
        while(option != 4)
        {
            DisplayMenu();
            option = int.Parse(Console.ReadLine());
            Console.Clear();
            if(option == 1)
            {
                BreathingActivity breathingActivity = new();
                breathingActivity.DisplayStartingMessage();
                breathingActivity.Run();
                breathingActivity.DisplayEndingMessage();
                
            }
            if(option == 2)
            {
                ReflectingActivity reflectingActivity = new();
                reflectingActivity.DisplayStartingMessage();
                reflectingActivity.Run();
                reflectingActivity.DisplayEndingMessage();
            }
            if(option == 3)
            {
                ListingActivity listingActivity = new();
                listingActivity.DisplayStartingMessage();
                listingActivity.Run();
                listingActivity.DisplayEndingMessage();
            }
        }
    }
    static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");
    }
}