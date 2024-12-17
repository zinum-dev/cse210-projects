using System.Text.Json;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = [];
        _score = 0;
    }

    public void Start()
    {
        int option = 0;
        while (option != 6)
        {
            DisplayMenu();
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                CreateGoal();
            }
            if (option == 2)
            {
                ListGoalDetails();
            }
            if (option == 3)
            {
                SaveGoals();
            }
            if (option == 4)
            {
                LoadGoals();
            }
            if (option == 5)
            {
                RecordEvent();
            }
        }

    }

    private void DisplayMenu()
    {
        DisplayPlayerInfo();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("\t1. Create New Goal");
        Console.WriteLine("\t2. List Goals");
        Console.WriteLine("\t3. Save Goals");
        Console.WriteLine("\t4. Load Goals");
        Console.WriteLine("\t5. Record Event");
        Console.WriteLine("\t6. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }

    public void ListGoalNames()
    {
        
    }

    public void ListGoalDetails()
    {
        int index = 1;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetDetailsString()}");
            index++;
        }
        
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("\t2. Eternal Goal");
        Console.WriteLine("\t3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int goalType = int.Parse(Console.ReadLine());
        
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        
        if (goalType == 1){
            SimpleGoal simpleGoal = new SimpleGoal(name, description,points);
            _goals.Add(simpleGoal);
        }
        if (goalType == 2){
            EternalGoal eternalGoal = new EternalGoal(name, description,points);
            _goals.Add(eternalGoal);
        }   
        if (goalType == 3){
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklistGoal = new ChecklistGoal(name, description,points,target,bonus);
            _goals.Add(checklistGoal);
        }
    }

    public void RecordEvent()
    {
        
    }

    public void SaveGoals()
    {
        string filename = "goals.txt";
        var options = new JsonSerializerOptions { WriteIndented = true };
        string fileString = $"{ _score }\n";
                            

        foreach (var goal in _goals)
        {
            var type = goal.GetType();
            if (type == typeof(SimpleGoal))
            {
                fileString += $"SimpleGoal|{goal.GetShortName()}|{goal.GetDescription()}|{goal.GetPoints()}|{goal.IsComplete()}";
            }
            if (type == typeof(EternalGoal))
            {
                fileString += $"EternalGoal|{goal.GetShortName()}|{goal.GetDescription()}|{goal.GetPoints()}";
            }
            if (goal is ChecklistGoal checklistGoal)
            {
                ChecklistGoal auxGoal = goal as ChecklistGoal;
                fileString += $"ChecklistGoal|{auxGoal.GetShortName()}|{auxGoal.GetDescription()}|{auxGoal.GetPoints()}|{auxGoal.GetBonus()}|{auxGoal.GetTarget()}|{auxGoal.GetAmountCompleted()}";
            }
        }
        File.WriteAllText(filename, fileString);
    }    

    public void LoadGoals()
    {
        string filename = "goals.txt";
        if (File.Exists(filename))
        {
            string jsonString = File.ReadAllText(filename);



            var template = new { _score = 0, _goals = new List<Goal>() };
            var data = JsonSerializer.Deserialize(jsonString, template.GetType());
            
            _score = ((dynamic)data)._score;
            _goals = ((dynamic)data)._goals;
            
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}