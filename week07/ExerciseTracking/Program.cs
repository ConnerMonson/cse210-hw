using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running(4.5, 45, "15 June 2026"));
        activities.Add(new Cycling(15, 55, "15 June 2026"));
        activities.Add(new Swimming(50, 60, "15 June 2026"));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}