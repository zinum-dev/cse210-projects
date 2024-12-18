public abstract class Activity
{
    protected DateTime _date;
    protected double _duration;
    
    public Activity(DateTime date, double duration)
    {
        _date = date;
        _duration = duration;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public abstract string GetActivity();
    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetActivity()} ({_duration} min): Distance {GetDistance():F1} Km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F2} min per km";
    } 

}