// Running class inheriting from Activity
public class Running : Activity
{
    // Private member variable to store the distance (in miles)
    private double distance;

    // Constructor to initialize the running activity
    public Running(DateTime date, int length, double distance)
        : base(date, length)
    {
        this.distance = distance;
    }

    // Override methods to return distance, speed, and pace
    public override double GetDistance() => distance;
    public override double GetSpeed() => (distance / Length) * 60;
    public override double GetPace() => Length / distance;
}
