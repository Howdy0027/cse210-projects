// EternalGoal class inherits from the abstract Goal class
public class EternalGoal : Goal
{
    // Constructor for EternalGoal, takes name, description, and points as parameters
    // Calls the base class constructor to initialize the inherited fields
    public EternalGoal(string name, string description, string points)
        : base(name, description, points)
    {
    }

    // Override the RecordEvent method from the Goal class
    // Since eternal goals are never completed, no specific action is taken here
    public override void RecordEvent()
    {
        // Eternal goals are never completed, just increment points
    }

    // Override the IsComplete method from the Goal class
    // Eternal goals are never complete, so always return false
    public override bool IsComplete() => false;

    // Override the GetStringRepresentation method from the Goal class
    // Returns a string representation of the eternal goal
    public override string GetStringRepresentation()
    {
        return $"EternalGoal,{GetShortName()},{GetDescription()},{GetPoints()}";
    }
}