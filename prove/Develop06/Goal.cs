public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public string GetShortName() => _shortName;
    public void SetShortName(string shortName) => _shortName = shortName;

    public string GetDescription() => _description;
    public void SetDescription(string description) => _description = description;

    public int GetPoints() => _points;
    public void SetPoints(int points) => _points = points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetStringRepresentation();

    public virtual string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {_shortName} ({_description})";
        }
        return $"[ ] {_shortName} ({_description})";
    }

}