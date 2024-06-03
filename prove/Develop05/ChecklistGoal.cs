// ChecklistGoal class inherits from the abstract Goal class
public class ChecklistGoal : Goal
{
    // Private fields to store the amount completed, target, and bonus for the goal
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // Constructor for ChecklistGoal, takes name, description, points, target, and bonus as parameters
    // Calls the base class constructor to initialize the inherited fields
    // Initializes the _amountCompleted field to 0
    public ChecklistGoal(string name, string description, string points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    // Override the RecordEvent method from the Goal class
    // Increments the _amountCompleted field by 1
    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    // Public method to set the _amountCompleted field
    public void SetAmountCompleted(int amount) => _amountCompleted = amount;

    // Override the IsComplete method from the Goal class
    // Returns true if the amount completed is greater than or equal to the target
    public override bool IsComplete() => _amountCompleted >= _target;

    // Override the GetDetailsString method from the Goal class
    // Returns a string representation of the goal's details, including its completion status and amount completed
    public override string GetDetailsString()
    {
        return $"[ {(IsComplete() ? "X" : " ")} ] {base.GetDetailsString()} (Completed {_amountCompleted}/{_target} times)";
    }

    // Override the GetStringRepresentation method from the Goal class
    // Returns a string that includes the goal's type, name, description, points, target, bonus, and amount completed
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{GetShortName()},{GetDescription()},{GetPoints()},{_target},{_bonus},{_amountCompleted}";
    }
}