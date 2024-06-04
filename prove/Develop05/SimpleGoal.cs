public class SimpleGoal : Goal
{
    // Private member variable to track completion status
    private bool _isComplete;

    // Constructor to initialize SimpleGoal attributes
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false; // Initially not complete
    }

    // Method to record the event and mark the goal as complete
    public override void RecordEvent()
    {
        _isComplete = true;
    }

    // Method to check if the goal is complete
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // Method to get detailed information about the goal
    public override string GetDetailString()
    {
        return $"SimpleGoal: {_shortName}, {_description}, Points: {_points}, Completed: {_isComplete}";
    }

    // Method to get a string representation of the goal for saving/loading
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }
}