class Cycling :Activity
{    
    private double _speed; //km/h
    public Cycling(DateTime date, double duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance() //km
    {
        return _speed * (_duration/60);
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
        return "Cycling";
    }

}