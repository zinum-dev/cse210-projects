class Running :Activity
{    
    private double _distance; // km
    public Running(DateTime date, double duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()//km/h
    {
        return  _distance / _duration * 60;
    }

    public override double GetPace() //min/km
    {
        return _duration / _distance;
    }

    public override string GetActivity()
    {
        return "Running";
    }
}