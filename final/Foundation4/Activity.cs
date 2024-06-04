// Base Activity class
public abstract class Activity
{
    // Properties to store the date and length (in minutes) of the activity
    public DateTime Date { get; set; }
    public int Length { get; set; }

    // Constructor to initialize the activity
    public Activity(DateTime date, int length)
    {
        Date = date;
        Length = length;
    }

    // Abstract methods to be implemented by derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Virtual method to return a summary of the activity
    public virtual string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} {this.GetType().Name} ({Length} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}