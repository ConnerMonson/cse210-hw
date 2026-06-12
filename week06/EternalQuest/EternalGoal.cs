class EternalGoal: Goal
{
    public EternalGoal(string name, string description, int duration)
    : base(name, description, duration)
    {
    }

    public override int RecordEvent()
    {
        return GetPoints();
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetDetailsString()
    {
        return $"[∞] {GetName()}";
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{GetName()}|{GetDescription()}|{GetPoints()}";
    }

}