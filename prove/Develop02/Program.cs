using System.Text.Json;

// Journal storage as a JSON file, and add the file name as the journal name.
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your journal !");

        int option = 0;
        Journal journal = new();

        while (option != 5)
        {
            DisplayMenu();
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Registry registry = new();
                registry.Write(GetPrompt());
                journal._registries.Add(registry);
            }
            if (option == 2)
            {
                journal.Display();
            }
            if (option == 3)
            {
                Console.WriteLine("What is the file name? (without extension)");
                string filename = Console.ReadLine();
                journal = Load(filename);
            }
            if (option == 4)
            {
                Console.WriteLine("What is the file name? (without extension)");
                string filename = Console.ReadLine();
                Save(filename, journal);
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. New entry");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
    }

    static void Save(string filename, Journal journal)
    {
        journal._name = filename;
        filename += ".json";
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(journal, options);

        File.WriteAllText(filename, jsonString);

    }

    static Journal Load(string filename)
    {
        filename += ".json";
        if (File.Exists(filename))
        {
            string jsonString = File.ReadAllText(filename);
            return JsonSerializer.Deserialize<Journal>(jsonString);
        }
        else
        {
            Console.WriteLine("File not found.");
            return null;
        }
    }

    static string GetPrompt()
    {
        List<string> prompts = [
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What specific event or situation did not go as planned today?",
            "How did you react to the situations of the day?",
            "Tell me a joke",
            "What is something I am grateful for today?",
            "What is something I am looking forward to tomorrow?"
            ];

        Random random = new Random();

        return prompts[random.Next(0, prompts.Count)];
    }


}