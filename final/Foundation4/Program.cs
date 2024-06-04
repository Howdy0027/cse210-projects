// Program class
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create activity instances
        Activity running = new Running(new DateTime(2023, 6, 1), 30, 3.0); // 3 miles
        Activity cycling = new Cycling(new DateTime(2023, 6, 2), 45, 20.0); // 20 mph
        Activity swimming = new Swimming(new DateTime(2023, 6, 3), 60, 40); // 40 laps

        // Add activities to a list
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Iterate through the list and display summaries for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}