using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        Console.WriteLine("Creating sample goals...");
        // Sample goals
        goalManager.CreateGoal(new SimpleGoal("Run Marathon", "Complete a full marathon", 1000));
        goalManager.CreateGoal(new EternalGoal("Read Scriptures", "Read scriptures daily", 100));
        goalManager.CreateGoal(new ChecklistGoal("Attend Temple", "Attend the temple 10 times", 50, 10, 500));

        Console.WriteLine("Initial player info and goals:");
        goalManager.DisplayPlayerInfo();
        goalManager.ListGoalNames();
        goalManager.ListGoalDetails();

        Console.WriteLine("\nRecording some events...");
        // Record some events
        goalManager.RecordEvent("Run Marathon");
        goalManager.RecordEvent("Read Scriptures");
        goalManager.RecordEvent("Attend Temple");
        goalManager.RecordEvent("Attend Temple");

        Console.WriteLine("\nUpdated player info and goals:");
        goalManager.DisplayPlayerInfo();
        goalManager.ListGoalDetails();

        // Save and load goals (file operations)
        string filename = "goals.txt";
        Console.WriteLine($"\nSaving goals to {filename}...");
        goalManager.SaveGoals(filename);
        Console.WriteLine("Goals saved.");

        Console.WriteLine("\nLoading goals from file...");
        goalManager.LoadGoals(filename);
        Console.WriteLine("Goals loaded.");

        Console.WriteLine("\nPlayer info and goals after loading from file:");
        goalManager.DisplayPlayerInfo();
        goalManager.ListGoalDetails();
    }
}