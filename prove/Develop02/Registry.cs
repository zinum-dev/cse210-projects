using System.ComponentModel.DataAnnotations;

class Registry
{
    public string _prompt { get; set; }
    public string _response { get; set; }
    public DateTime _date { get; set; } = DateTime.Today;
    public Registry()
    {
    }

    public void Write(string prompt)
    {
        Console.WriteLine(prompt);
        _prompt = prompt;
        _response = Console.ReadLine();
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date.ToString("MM/dd/yyyy")} - Prompt: {_prompt}");
        Console.WriteLine($"{_response}");
    }

}