class Swimming: Activity
{
    private double _laps;
    public Swimming(double laps, int minutes, string date): base(minutes, date)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double distance = _laps * 50 / 1000 * .62;
        return distance;
    }
    public override double GetSpeed()
    {
        double speed = (GetDistance() / _minutes) * 60;
        return speed;
    }
    public override double GetPace()
    {
        double pace = 60 / GetSpeed();
        return pace;
    }
    public override string GetActivityType()
    {
        return "Swimming";
    }
}