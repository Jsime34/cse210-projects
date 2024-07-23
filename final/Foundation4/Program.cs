using System;

class Program
{
    static void Main(string[] args)
    {
        Activity running = new Running("11/03/2024", 30, 3.0); // 3 miles
        Activity cycling = new Cycling("12/02/2024", 45, 15.0); // 15 mph
        Activity swimming = new Swimming("08/07/2024", 60, 30); // 30 laps

        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.getSummary());
        }
    }
}