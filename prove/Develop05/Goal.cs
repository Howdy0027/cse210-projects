using System;

public abstract class Goal
{
    // Protected member variables accessible to derived classes
    protected string _shortName;
    protected string _description;
    protected int _points;

    // Constructor to initialize the base attributes
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Abstract methods to be implemented by derived classes
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailString();
    public abstract string GetStringRepresentation();

    // Public property to access points
    public int Points => _points;
}