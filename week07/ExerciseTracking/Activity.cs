abstract class Activity
{
    private string _date;
    protected int _minutes;
    public Activity(int minutes, string date)
    {
        _minutes = minutes;
        _date = date;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetActivityType();
    public virtual string GetSummary()
    {
        return $"{_date} {GetActivityType()} ({_minutes} min)- Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}