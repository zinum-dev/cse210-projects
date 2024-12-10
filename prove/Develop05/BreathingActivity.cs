class BreathingActivity : Activity
{

    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing")
    {
        
    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        while (DateTime.Now < futureTime)
        {
            Console.Write("\nBreathe in...");
            ShowCountDown(4);
            Console.Write("\nBreathe out...");
            ShowCountDown(5);
            Console.WriteLine();
        }        
    }    
}
