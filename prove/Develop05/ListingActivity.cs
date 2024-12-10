class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        ];
    }

    public void Run()
    {
        Console.WriteLine("List as many responses you can to the following prompt:"); 
        Console.WriteLine($"--- {GetRandomPrompt()} ---"); 
        Console.Write("You may begin in: "); 
        ShowCountDown(5);
        Console.WriteLine("");
        List<string> responses =  GetListFromUser();
        Console.WriteLine($"You listed {responses.Count} items!");

    }   

    public string GetRandomPrompt() 
    {
        Random random = new Random();
        return _prompts[random.Next(0, _prompts.Count)];
    }

    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);


        while (DateTime.Now < futureTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            responses.Add(response);
        }   
        return responses;
    }


}
