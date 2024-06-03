using System; // Importing the System namespace for basic functionality
using System.Collections.Generic; // Importing the namespace for using List<T>
using System.IO; // Importing the namespace for file I/O operations

public class GoalManager
{
    // Private field to store a list of goals
    private List<Goal> _goals;
    // Private field to store the score
    private int _score;

    // Constructor to initialize the fields
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    // Method to start goal management (implementation can be added as needed)
    public void Start()
    {
        // Implement the logic to start the goal management
    }

    // Method to display the player's current score
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
    }

    // Method to list the names of all goals
    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
    }

    // Method to list the details of all goals
    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    // Method to add a new goal to the list
    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    // Method to record an event for a goal at a specified index
    public void RecordEvent(int goalIndex)
    {
        // Check if the goal index is valid
        if (goalIndex < 0 || goalIndex >= _goals.Count)
        {
            Console.WriteLine("Invalid goal index.");
            return;
        }

        // Get the goal at the specified index
        Goal goal = _goals[goalIndex];
        // Record the event for the goal
        goal.RecordEvent();
        // Update the score with the points from the goal
        _score += int.Parse(goal.GetPoints());
    }

    // Method to save the goals and the score to a file
    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // Write each goal's string representation to the file
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
            // Write the score to the file
            outputFile.WriteLine(_score);
        }
    }

    // Method to load the goals and the score from a file
    public void LoadGoals(string filename)
    {
        // Check if the file exists
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        // Read all lines from the file
        string[] lines = File.ReadAllLines(filename);
        _goals.Clear();
        // Process each line to recreate the goals
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');

            string type = parts[0];
            if (type == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(parts[1], parts[2], parts[3]);
                goal.SetComplete(bool.Parse(parts[4]));
                _goals.Add(goal);
            }
            else if (type == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal(parts[1], parts[2], parts[3]);
                _goals.Add(goal);
            }
            else if (type == "ChecklistGoal")
            {
                ChecklistGoal goal = new ChecklistGoal(parts[1], parts[2], parts[3], int.Parse(parts[4]), int.Parse(parts[5]));
                goal.SetAmountCompleted(int.Parse(parts[6]));
                _goals.Add(goal);
            }
        }
        // Update the score from the last line of the file
        _score = int.Parse(lines[^1]);
    }
}