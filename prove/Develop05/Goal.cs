// Abstract base class Goal
public abstract class Goal
{
    // Private fields to store the short name, description, and points of the goal
    private string _shortName;
    private string _description;
    private string _points;

    // Constructor to initialize the fields
    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Public method to get the short name of the goal
    public string GetShortName() => _shortName;

    // Public method to get the description of the goal
    public string GetDescription() => _description;

    // Public method to get the points of the goal
    public string GetPoints() => _points;

    // Abstract method to record an event for the goal
    // Must be implemented by derived classes
    public abstract void RecordEvent();

    // Abstract method to check if the goal is complete
    // Must be implemented by derived classes
    public abstract bool IsComplete();

    // Virtual method to get the details of the goal as a string
    // Can be overridden by derived classes if needed
    public virtual string GetDetailsString()
    {
        return $"{_shortName}: {_description} ({_points} points)";
    }

    // Abstract method to get a string representation of the goal
    // Must be implemented by derived classes
    public abstract string GetStringRepresentation();
}