class Running: Activity
{
    private double _distance;

    public Running(double distance, int minutes, string date): base(minutes, date)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        double speed = (_distance / _minutes) * 60;
        return speed;
    }
    public override double GetPace()
    {
        double pace = _minutes / _distance;
        return pace;
    }
    public override string GetActivityType()
    {
        return "Running";
    }
}