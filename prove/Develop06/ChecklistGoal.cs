
class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target; 
    private int _bonus; 

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus) : base(shortName,  description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public int GetAmountCompleted() => _amountCompleted;
    public void SetAmountCompleted(int amount) => _amountCompleted = amount;
    public int GetTarget() => _target;
    public void SetTarget(int target) => _target = target;
    public int GetBonus() => _bonus;
    public void SetBonus(int bonus) => _bonus = bonus;

    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }

    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {GetShortName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        return $"[ ] {GetShortName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
    }
}