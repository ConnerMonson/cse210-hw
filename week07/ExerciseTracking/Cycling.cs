class Cycling: Activity
{
    private double _speed;
    public Cycling(double speed, int minutes, string date): base(minutes, date)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double distance = (_speed / 60) * _minutes;
        return distance;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        double pace = 60 / _speed;
        return pace;
    }
    public override string GetActivityType()
    {
        return "Cycling";
    }
}