public class EternalGoal : Goal
{
    // Constructor to initialize EternalGoal attributes
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    // Method to record the event (eternal goals never complete)
    public override void RecordEvent()
    {
        // No completion state change for eternal goals
    }

    // Method to check if the goal is complete (always false for eternal goals)
    public override bool IsComplete()
    {
        return false;
    }

    // Method to get detailed information about the goal
    public override string GetDetailString()
    {
        return $"EternalGoal: {_shortName}, {_description}, Points: {_points}";
    }

    // Method to get a string representation of the goal for saving/loading
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}