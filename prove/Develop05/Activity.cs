class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name} Activity");
        Console.WriteLine($"\n{_description}\n");
        Console.Write($"How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!");
        Thread.Sleep(0);
        ShowSpinner(7);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(7);
    }    

    public void ShowSpinner(int seconds)
    {
        Thread.Sleep(seconds * 1000);
        Console.WriteLine($"Spinner");
    }    

    public void ShowCountDown(int seconds)
    {
        Thread.Sleep(seconds * 1000);
        Console.WriteLine($"Count Down");
    }    

}
