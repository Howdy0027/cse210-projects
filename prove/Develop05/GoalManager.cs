using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    // Private member variables to store goals and score
    private List<Goal> _goals;
    private int _score;

    // Constructor to initialize the GoalManager
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    // Method to start the goal manager (implementation details omitted)
    public void Start()
    {
        // Implementation for starting the goal manager
    }

    // Method to display player's score
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
    }

    // Method to list all goal names
    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    // Method to list detailed information for all goals
    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailString());
        }
    }

    // Method to create and add a new goal to the list
    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    // Method to record an event for a specific goal and update score
    public void RecordEvent(string goalName)
    {
        foreach (var goal in _goals)
        {
            if (goal.GetStringRepresentation().Contains(goalName))
            {
                goal.RecordEvent();
                _score += goal.Points;

                // Additional points for completing checklist goals
                if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
                {
                    _score += checklistGoal.Bonus;
                }
                break;
            }
        }
    }

    // Method to save goals to a file
    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    // Method to load goals from a file
    public void LoadGoals(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
            string type = parts[0];
            string[] goalData = parts[1].Split(",");

            // Create goals based on the type and add to the list
            if (type == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(goalData[0], goalData[1], int.Parse(goalData[2]));
                if (bool.Parse(goalData[3]))
                {
                    goal.RecordEvent();
                }
                _goals.Add(goal);
            }
            else if (type == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal(goalData[0], goalData[1], int.Parse(goalData[2]));
                _goals.Add(goal);
            }
            else if (type == "ChecklistGoal")
            {
                ChecklistGoal goal = new ChecklistGoal(goalData[0], goalData[1], int.Parse(goalData[2]), int.Parse(goalData[4]), int.Parse(goalData[5]));
                for (int i = 0; i < int.Parse(goalData[3]); i++)
                {
                    goal.RecordEvent();
                }
                _goals.Add(goal);
            }
        }
    }
}