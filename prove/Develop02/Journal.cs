class Journal
{
    
    public string _name { get; set; }
    public List<Registry> _registries { get; set; } = [];
    public Journal()
    {
    }

    public void Display()
    {
        Console.WriteLine($"{_name} journal");
        foreach (var registry in _registries)
        {
            registry.Display();
            Console.WriteLine("");
        }
    }

}