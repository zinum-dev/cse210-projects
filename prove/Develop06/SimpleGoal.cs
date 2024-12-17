using System.Text.Json.Serialization;

class SimpleGoal : Goal
{
    [JsonInclude] 
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int points) : base(shortName,  description, points)
    {
        _isComplete = false;
    }

    public SimpleGoal(string shortName, string description, int points, bool isComplete) : base(shortName,  description, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}