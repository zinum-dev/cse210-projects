class Swimming :Activity
{    
    private int _numLaps; // 50m
    public Swimming(DateTime date, double duration, int numLaps) : base(date, duration)
    {
        _numLaps = numLaps;
    }

    public override double GetDistance()
    {
        return _numLaps * 50.0 / 1000.0;
    }

    public override double GetSpeed()//km/h
    {
        return  GetDistance() / _duration * 60;
    }

    public override double GetPace() //min/km
    {
        return _duration / GetDistance();
    }

    public override string GetActivity()
    {
        return "Swimming";
    }

}