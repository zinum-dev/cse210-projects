// I stored the scriptures in a JSON file and created a class to read the JSON file and return the data.  
// I hide the words according to the size of the scripture, with a maximum of 10 iterations.  
// The words hidden are never the same.  
// The user can choose which scripture they want to try to memorize.  

using System.Text.Json;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the scripture memorizer!");

        string filename = "scripturesStorage.json";
        List<Storage> storageList = LoadScriptures(filename);
        Scripture scripture = ChooseScripture(storageList);

        string quit = "";
        while (quit != "quit")
        {
            Console.Clear();
            Console.WriteLine($"{scripture.GetDisplayText()}");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            quit = Console.ReadLine();

            if(scripture.IsCompletelyHidden())
            {
                break;
            }

            scripture.HideRandomWords();
        }
    }

    private static Scripture ChooseScripture(List<Storage> storageList)
    {
        Console.WriteLine("Please choose a scripture:");
        for (int i = 0; i < storageList.Count; i++)
        {
            Console.WriteLine($"[{i + 1}]  {storageList[i].GetReference().GetDisplayText()}");
        }
        int scriptureNumber = int.Parse(Console.ReadLine());

        Reference reference = storageList[scriptureNumber - 1].GetReference();
        string scriptureText = storageList[scriptureNumber - 1].GetScripture();

        return new Scripture(reference, scriptureText);
    }

    private static List<Storage> LoadScriptures(string filename)
    {
        string json = File.ReadAllText(filename);
        List<Storage> storageList = [];

        using (JsonDocument doc = JsonDocument.Parse(json))
        {
            JsonElement root = doc.RootElement;

            foreach (JsonElement item in root.EnumerateArray())
            {
                Storage storage = new Storage();
                if (item.TryGetProperty("_reference", out JsonElement referenceJson))
                {
                    string book = referenceJson.GetProperty("_book").GetString();
                    string chapter = referenceJson.GetProperty("_chapter").GetString();
                    string verse = referenceJson.GetProperty("_verse").GetString();
                    string endVerse = referenceJson.TryGetProperty("_endVerse", out JsonElement ev) ? ev.GetString() : null;

                    if(endVerse is not null)
                    {
                        Reference reference = new(book, int.Parse(chapter), int.Parse(verse), int.Parse(endVerse));
                        storage.SetReference(reference);
                    }
                    else
                    {
                        Reference reference = new(book, int.Parse(chapter), int.Parse(verse));
                        storage.SetReference(reference);
                    }
                }

                if (item.TryGetProperty("_scripture", out JsonElement scripture))
                {
                    storage.SetScripture(scripture.GetString());
                }
                storageList.Add(storage);
            }
        }
        return storageList;
    }
}