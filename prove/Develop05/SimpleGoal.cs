// The SimpleGoal class inherits from the abstract Goal class
public class SimpleGoal : Goal
{
    // Private field to track whether the goal is complete
    private bool _isComplete;

    // Constructor for SimpleGoal, takes name, description, and points as parameters
    // Calls the base class constructor to initialize the inherited fields
    public SimpleGoal(string name, string description, string points)
        : base(name, description, points)
    {
        // Initialize the _isComplete field to false, indicating the goal is not yet complete
        _isComplete = false;
    }

    // Override the RecordEvent method from the Goal class
    // Sets _isComplete to true, marking the goal as completed
    public override void RecordEvent()
    {
        _isComplete = true;
    }

    // Override the IsComplete method from the Goal class
    // Returns the current completion status of the goal
    public override bool IsComplete() => _isComplete;

    // Public method to set the _isComplete field, allowing external code to mark the goal as complete or incomplete
    public void SetComplete(bool complete) => _isComplete = complete;

    // Override the GetDetailsString method from the Goal class
    // Returns a string representation of the goal's details, including its completion status
    public override string GetDetailsString()
    {
        // Use a ternary operator to include a check mark if the goal is complete, or a space if it is not
        return $"[ {(IsComplete() ? "X" : " ")} ] {base.GetDetailsString()}";
    }

    // Override the GetStringRepresentation method from the Goal class
    // Returns a string that includes the goal's type, name, description, points, and completion status
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,{GetShortName()},{GetDescription()},{GetPoints()},{_isComplete}";
    }
}

