// Swimming class inheriting from Activity
public class Swimming : Activity
{
    // Private member variable to store the number of laps
    private int laps;
    // Constant for the distance of a lap in miles
    private const double lapDistance = 50.0 / 1609.34; // 50 meters to miles

    // Constructor to initialize the swimming activity
    public Swimming(DateTime date, int length, int laps)
        : base(date, length)
    {
        this.laps = laps;
    }

    // Override methods to return distance, speed, and pace
    public override double GetDistance() => laps * lapDistance;
    public override double GetSpeed() => (GetDistance() / Length) * 60;
    public override double GetPace() => Length / GetDistance();
}