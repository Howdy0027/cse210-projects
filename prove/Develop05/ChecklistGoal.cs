public class ChecklistGoal : Goal
{
    // Private member variables to track progress and target
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // Constructor to initialize ChecklistGoal attributes
    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0; // Initially no progress
        _target = target;
        _bonus = bonus;
    }

    // Method to record the event and increment progress
    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    // Method to check if the goal is complete
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    // Method to get detailed information about the goal
    public override string GetDetailString()
    {
        return $"ChecklistGoal: {_shortName}, {_description}, Points: {_points}, Completed: {_amountCompleted}/{_target}, Bonus: {_bonus}";
    }

    // Method to get a string representation of the goal for saving/loading
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }

    // Public property to access bonus
    public int Bonus => _bonus;
}